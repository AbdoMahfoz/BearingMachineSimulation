using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using BearingMachineModels;
using BearingMachineSimulation;

namespace BearingMachineSimulation
{
    static class NetworkManager
    {
        private static Socket TCPSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static Socket UDPSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private static List<Socket> ConnectedSockets = new List<Socket>();
        private static Thread BroadCastThread, AcceptConnectionsThread, ClientSideThread;
        private static bool AllowedToAnnounce;
        private static void AnnouncePresence()
        {
            while (true)
            {
                while(!AllowedToAnnounce)
                {
                    Monitor.Wait(AllowedToAnnounce);
                }
                UDPSocket.SendTo(Encoding.ASCII.GetBytes("BearingMachine Server Here, come join us :)"), new IPEndPoint(IPAddress.Broadcast, 8500));
                Thread.Sleep(1000);
            }
        }
        private static void AcceptConnections()
        {
            while(true)
            {
                while (!AllowedToAnnounce)
                {
                    Monitor.Wait(AllowedToAnnounce);
                }
                ConnectedSockets.Add(TCPSocket.Accept());
            }
        }
        private static void TransmitData(Socket socket, SimulationSystem system)
        {
            socket.Send(Encoding.ASCII.GetBytes(system.DowntimeCost.ToString()));
            socket.Send(Encoding.ASCII.GetBytes(system.RepairPersonCost.ToString()));
            socket.Send(Encoding.ASCII.GetBytes(system.BearingCost.ToString()));
            socket.Send(Encoding.ASCII.GetBytes(system.NumberOfHours.ToString()));
            socket.Send(Encoding.ASCII.GetBytes(system.NumberOfBearings.ToString()));
            socket.Send(Encoding.ASCII.GetBytes(system.RepairTimeForOneBearing.ToString()));
            socket.Send(Encoding.ASCII.GetBytes(system.RepairTimeForAllBearings.ToString()));
            foreach (List<TimeDistribution> l in new List<TimeDistribution>[] { system.DelayTimeDistribution, system.BearingLifeDistribution })
            {
                socket.Send(Encoding.ASCII.GetBytes(l.Count.ToString()));
                foreach (TimeDistribution distribution in l)
                {
                    socket.Send(Encoding.ASCII.GetBytes(distribution.Time.ToString() + " " + distribution.Probability.ToString()));
                }
            }
        }
        private static void TransmitData(Socket socket, List<CurrentSimulationCase> Table, PerformanceMeasures Performance)
        {
            socket.Send(Encoding.ASCII.GetBytes(Table.Count.ToString()));
            foreach(CurrentSimulationCase Case in Table)
            {
                socket.Send(Encoding.ASCII.GetBytes(Case.Bearing.RandomHours + " " + Case.Bearing.Hours + " " +
                                                    Case.RandomDelay + " " + Case.Delay + " " + Case.AccumulatedHours));
            }
            socket.Send(Encoding.ASCII.GetBytes(Performance.BearingCost + " " + Performance.DelayCost + " " + Performance.DowntimeCost +
                                                " " + Performance.RepairPersonCost + " " + Performance.TotalCost));
        }
        private static void RecieveData(Socket socket, SimulationSystem system)
        {
            byte[] buffer = new byte[1024];
            int n = socket.Receive(buffer);
            system.DowntimeCost = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            system.RepairPersonCost = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            system.BearingCost = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            system.NumberOfHours = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            system.NumberOfBearings = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            system.RepairTimeForOneBearing = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            system.RepairTimeForAllBearings = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
            n = socket.Receive(buffer);
            foreach (List<TimeDistribution> l in new List<TimeDistribution>[] { system.DelayTimeDistribution, system.BearingLifeDistribution })
            {
                int len = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
                for (int i = 0; i < len; i++)
                {
                    TimeDistribution distribution = new TimeDistribution();
                    n = socket.Receive(buffer);
                    int time = int.Parse(Encoding.ASCII.GetString(buffer, 0, n));
                    n = socket.Receive(buffer);
                    decimal probability = decimal.Parse(Encoding.ASCII.GetString(buffer, 0, n));
                    distribution.Time = time;
                    distribution.Probability = probability;
                    l.Add(distribution);
                }
            }
        }
        private static void RecieveData(Socket socket, List<CurrentSimulationCase> Table, PerformanceMeasures Performance)
        {
            byte[] buffer = new byte[1024];
            int n = socket.Receive(buffer);
            int len = int.Parse(Encoding.ASCII.GetString(buffer));
            for(int i = 0; i < len; i++)
            {
                CurrentSimulationCase Case = new CurrentSimulationCase();
                n = socket.Receive(buffer);
                Case.Bearing.RandomHours = int.Parse(Encoding.ASCII.GetString(buffer));
                n = socket.Receive(buffer);
                Case.Bearing.Hours = int.Parse(Encoding.ASCII.GetString(buffer));
                n = socket.Receive(buffer);
                Case.RandomDelay = int.Parse(Encoding.ASCII.GetString(buffer));
                n = socket.Receive(buffer);
                Case.Delay = int.Parse(Encoding.ASCII.GetString(buffer));
                n = socket.Receive(buffer);
                Case.AccumulatedHours = int.Parse(Encoding.ASCII.GetString(buffer));
                Table.Add(Case);
            }
            n = socket.Receive(buffer);
            Performance.BearingCost = decimal.Parse(Encoding.ASCII.GetString(buffer));
            n = socket.Receive(buffer);
            Performance.DelayCost = decimal.Parse(Encoding.ASCII.GetString(buffer));
            n = socket.Receive(buffer);
            Performance.DowntimeCost = decimal.Parse(Encoding.ASCII.GetString(buffer));
            n = socket.Receive(buffer);
            Performance.RepairPersonCost = decimal.Parse(Encoding.ASCII.GetString(buffer));
            n = socket.Receive(buffer);
            Performance.TotalCost = decimal.Parse(Encoding.ASCII.GetString(buffer));
        }
        private static void ServersideDataCommunication(object o)
        {
            SimulationSystem system = (SimulationSystem)((object[])o)[0];
            List<CurrentSimulationCase> Cases = (List<CurrentSimulationCase>)((object[])o)[1];
            Socket socket = (Socket)((object[])o)[2];
            TransmitData(socket, system);
            RecieveData(socket, Cases, system.CurrentPerformanceMeasures);
        }
        private static void ClientSideDataCommunication()
        {
            while (true)
            {
                SimulationSystem system = new SimulationSystem();
                RecieveData(TCPSocket, system);
                Simulator.CurrrentCalculateCase(system);
                TransmitData(TCPSocket, system.CurrentSimulationTable, system.CurrentPerformanceMeasures);
            }
        }
        public static void DistributeSystem(SimulationSystem system)
        {
            AllowedToAnnounce = false;
            int i = 1;
            List<List<CurrentSimulationCase>> Cases = new List<List<CurrentSimulationCase>>() { new List<CurrentSimulationCase>() };
            List<Thread> ActiveThreads = new List<Thread>();
            foreach(Socket s in ConnectedSockets)
            {
                if(i == system.NumberOfBearings)
                {
                    break;
                }
                List<CurrentSimulationCase> Bearing = new List<CurrentSimulationCase>();
                Cases.Add(Bearing);
                ActiveThreads.Add(new Thread(new ParameterizedThreadStart(ServersideDataCommunication)));
                ActiveThreads[ActiveThreads.Count - 1].Start(new object[]
                {
                    system.Clone(), Bearing, s
                });
                i++;
            }
            Simulator.CurrrentCalculateCase(system);
            foreach(Thread t in ActiveThreads)
            {
                t.Join();
            }
        }
        public static void InitiateServer(int MaxConnections)
        {
            UDPSocket.Bind(new IPEndPoint(IPAddress.Any, 8501));
            TCPSocket.Bind(new IPEndPoint(IPAddress.Any, 8502));
            TCPSocket.Listen(MaxConnections);
            BroadCastThread = new Thread(new ThreadStart(AnnouncePresence));
            AcceptConnectionsThread = new Thread(new ThreadStart(AcceptConnections));
            AllowedToAnnounce = true;
            BroadCastThread.Start();
            AcceptConnectionsThread.Start();
        }
        public static async Task<bool> ConnectToServer()
        {
            UDPSocket.Bind(new IPEndPoint(IPAddress.Any, 8500));
            TCPSocket.Bind(new IPEndPoint(IPAddress.Any, 8502));
            byte[] buffer = new byte[1024];
            EndPoint endPoint = new IPEndPoint(IPAddress.Any, 8501);
            int n;
            bool Success = true;
            await Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        n = UDPSocket.ReceiveFrom(buffer, ref endPoint);
                        if (Encoding.ASCII.GetString(buffer, 0, n) == "BearingMachine Server Here, come join us :)")
                        {
                            break;
                        }
                    }
                    TCPSocket.Connect(endPoint);
                }
                catch(Exception)
                {
                    Success = false;
                }
            });
            ClientSideThread = new Thread(new ThreadStart(ClientSideDataCommunication));
            ClientSideThread.Start();
            return Success;
        }
    }
}
