using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public static class StationeryHandler
    {
        public static List<MsStationery> getAllStationeries()
        {
            return StationeryRepo.getStationeries();
        }

        
        public static MsStationery getStationeryById(int id)
        {
            return StationeryRepo.GetStationeryById(id);
        }

        
        public static void createStationery(string stationeryName, int stationeryPrice)
        {
            
            StationeryRepo.createStationery(stationeryName, stationeryPrice);
        }

        
        public static void updateStationery(int id, string stationeryName, int stationeryPrice)
        {
            
            StationeryRepo.updateStationery(id, stationeryName, stationeryPrice);
        }

        
        public static void deleteStationery(int id)
        {
            StationeryRepo.deleteStationery(id);
        }
    }
}