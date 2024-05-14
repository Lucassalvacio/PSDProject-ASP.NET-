using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class StationeryFactory
    {
        public static MsStationery Create(string StationeryName, int StationeryPrice)
        {
            MsStationery msStationery = new MsStationery();
            msStationery.StationeryName = StationeryName;
            msStationery.StationeryPrice = StationeryPrice;
            return msStationery;
        }
    }
}