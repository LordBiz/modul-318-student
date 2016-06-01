using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, DateTime Date, DateTime Time);
        Connections GetConnections(string fromStation, string toStattion, DateTime Date, DateTime Time, bool isArrivalTime);
    }
}