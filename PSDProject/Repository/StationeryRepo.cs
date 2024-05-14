using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{ 
    public class StationeryRepo
    {
        UserDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<MsStationery> getStationeries()
        {
            return (from x in db.MsStationeries select x).ToList();
        }

        public MsStationery GetStationeryById(int id)
        {
            return (from x in db.MsStationeries where x.StationeryID == id select x).FirstOrDefault();
        }

        public void createStationery(string stationeryName, int stationeryPrice) 
        { 
            MsStationery stationery = StationeryFactory.Create(stationeryName, stationeryPrice);
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
        }

        public void updateStationery(int id, string stationeryName, int stationeryPrice)
        {
            MsStationery updateTemp = GetStationeryById(id);
            updateTemp.StationeryName = stationeryName;
            updateTemp.StationeryPrice = stationeryPrice;
            db.SaveChanges();
        }

        public void deleteStationery(int id)
        {
            db.MsStationeries.Remove(GetStationeryById(id));
            db.SaveChanges();
        }
    }
}