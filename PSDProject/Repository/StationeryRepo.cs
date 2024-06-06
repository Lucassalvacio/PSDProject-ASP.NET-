using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{ 
    public static class StationeryRepo
    {
        static UserDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<MsStationery> getStationeries()
        {
            return db.MsStationeries.ToList();
        }

        public static MsStationery GetStationeryById(int id)
        {
            return (from x in db.MsStationeries where x.StationeryID == id select x).FirstOrDefault();
        }

        public static void createStationery(string stationeryName, int stationeryPrice) 
        { 
            MsStationery stationery = StationeryFactory.Create(stationeryName, stationeryPrice);
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
        }

        public static void updateStationery(int id, string stationeryName, int stationeryPrice)
        {
            MsStationery updateTemp = GetStationeryById(id);
            updateTemp.StationeryName = stationeryName;
            updateTemp.StationeryPrice = stationeryPrice;
            db.SaveChanges();
        }

        public static void deleteStationery(int id)
        {
            db.MsStationeries.Remove(GetStationeryById(id));
            db.SaveChanges();
        }
    }
}