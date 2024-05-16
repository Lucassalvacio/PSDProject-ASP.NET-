using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class StationeryHandler
    {
        public List<MsStationery> GetAllStationeries()
        {
            return StationeryRepo.getStationeries();
        }

        
        public static MsStationery GetStationeryById(int id)
        {
            return StationeryRepo.GetStationeryById(id);
        }

        
        public static void CreateStationery(string stationeryName, int stationeryPrice)
        {
            
            StationeryRepo.createStationery(stationeryName, stationeryPrice);
        }

        
        public static void UpdateStationery(int id, string stationeryName, int stationeryPrice)
        {
            
            StationeryRepo.updateStationery(id, stationeryName, stationeryPrice);
        }

        
        public static void DeleteStationery(int id)
        {
            StationeryRepo.deleteStationery(id);
        }
    }
}