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

        
        public MsStationery GetStationeryById(int id)
        {
            return StationeryRepo.GetStationeryById(id);
        }

        
        public void CreateStationery(string stationeryName, int stationeryPrice)
        {
            
            StationeryRepo.createStationery(stationeryName, stationeryPrice);
        }

        
        public void UpdateStationery(int id, string stationeryName, int stationeryPrice)
        {
            
            StationeryRepo.updateStationery(id, stationeryName, stationeryPrice);
        }

        
        public void DeleteStationery(int id)
        {
            StationeryRepo.deleteStationery(id);
        }
    }
}