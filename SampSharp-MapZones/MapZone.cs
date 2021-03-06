using SampSharp.GameMode;
using SampSharp.GameMode.World;

namespace SampSharp.MapZones
{
    public class MapZone
    {
        private static readonly new MapZone[] _zones = new MapZone[] {
            new MapZone("Caligula's Palace", 2087.30f, 1543.20f, 900.00f, 2437.30f, 1703.20f, 1200.90f),
            new MapZone("The Four Dragons Casino", 1817.30f, 863.20f, 900.00f, 2027.30f, 1083.20f, 1200.90f),
            new MapZone("The Big Ear", -410.00f, 1403.30f, -3.00f, -137.90f, 1681.20f, 200.00f),
            new MapZone("Aldea Malvada", -1372.10f, 2498.50f, 0.00f, -1277.50f, 2615.30f, 200.00f),
            new MapZone("Angel Pine", -2324.90f, -2584.20f, -6.10f, -1964.20f, -2212.10f, 200.00f),
            new MapZone("Arco del Oeste", -901.10f, 2221.80f, 0.00f, -592.00f, 2571.90f, 200.00f),
            new MapZone("Avispa Country Club", -2646.40f, -355.40f, 0.00f, -2270.00f, -222.50f, 200.00f),
            new MapZone("Avispa Country Club", -2831.80f, -430.20f, -6.10f, -2646.40f, -222.50f, 200.00f),
            new MapZone("Avispa Country Club", -2361.50f, -417.10f, 0.00f, -2270.00f, -355.40f, 200.00f),
            new MapZone("Avispa Country Club", -2667.80f, -302.10f, -28.80f, -2646.40f, -262.30f, 71.10f),
            new MapZone("Avispa Country Club", -2470.00f, -355.40f, 0.00f, -2270.00f, -318.40f, 46.10f),
            new MapZone("Avispa Country Club", -2550.00f, -355.40f, 0.00f, -2470.00f, -318.40f, 39.70f),
            new MapZone("Back o Beyond", -1166.90f, -2641.10f, 0.00f, -321.70f, -1856.00f, 200.00f),
            new MapZone("Battery Point", -2741.00f, 1268.40f, -4.50f, -2533.00f, 1490.40f, 200.00f),
            new MapZone("Bayside", -2741.00f, 2175.10f, 0.00f, -2353.10f, 2722.70f, 200.00f),
            new MapZone("Bayside Marina", -2353.10f, 2275.70f, 0.00f, -2153.10f, 2475.70f, 200.00f),
            new MapZone("Beacon Hill", -399.60f, -1075.50f, -1.40f, -319.00f, -977.50f, 198.50f),
            new MapZone("Blackfield", 964.30f, 1203.20f, -89.00f, 1197.30f, 1403.20f, 110.90f),
            new MapZone("Blackfield", 964.30f, 1403.20f, -89.00f, 1197.30f, 1726.20f, 110.90f),
            new MapZone("Blackfield Chapel", 1375.60f, 596.30f, -89.00f, 1558.00f, 823.20f, 110.90f),
            new MapZone("Blackfield Chapel", 1325.60f, 596.30f, -89.00f, 1375.60f, 795.00f, 110.90f),
            new MapZone("Blackfield Intersection", 1197.30f, 1044.60f, -89.00f, 1277.00f, 1163.30f, 110.90f),
            new MapZone("Blackfield Intersection", 1166.50f, 795.00f, -89.00f, 1375.60f, 1044.60f, 110.90f),
            new MapZone("Blackfield Intersection", 1277.00f, 1044.60f, -89.00f, 1315.30f, 1087.60f, 110.90f),
            new MapZone("Blackfield Intersection", 1375.60f, 823.20f, -89.00f, 1457.30f, 919.40f, 110.90f),
            new MapZone("Blueberry", 104.50f, -220.10f, 2.30f, 349.60f, 152.20f, 200.00f),
            new MapZone("Blueberry", 19.60f, -404.10f, 3.80f, 349.60f, -220.10f, 200.00f),
            new MapZone("Blueberry Acres", -319.60f, -220.10f, 0.00f, 104.50f, 293.30f, 200.00f),
            new MapZone("Caligula's Palace", 2087.30f, 1543.20f, -89.00f, 2437.30f, 1703.20f, 110.90f),
            new MapZone("Caligula's Palace", 2137.40f, 1703.20f, -89.00f, 2437.30f, 1783.20f, 110.90f),
            new MapZone("Calton Heights", -2274.10f, 744.10f, -6.10f, -1982.30f, 1358.90f, 200.00f),
            new MapZone("Chinatown", -2274.10f, 578.30f, -7.60f, -2078.60f, 744.10f, 200.00f),
            new MapZone("City Hall", -2867.80f, 277.40f, -9.10f, -2593.40f, 458.40f, 200.00f),
            new MapZone("Come-A-Lot", 2087.30f, 943.20f, -89.00f, 2623.10f, 1203.20f, 110.90f),
            new MapZone("Commerce", 1323.90f, -1842.20f, -89.00f, 1701.90f, -1722.20f, 110.90f),
            new MapZone("Commerce", 1323.90f, -1722.20f, -89.00f, 1440.90f, -1577.50f, 110.90f),
            new MapZone("Commerce", 1370.80f, -1577.50f, -89.00f, 1463.90f, -1384.90f, 110.90f),
            new MapZone("Commerce", 1463.90f, -1577.50f, -89.00f, 1667.90f, -1430.80f, 110.90f),
            new MapZone("Commerce", 1583.50f, -1722.20f, -89.00f, 1758.90f, -1577.50f, 110.90f),
            new MapZone("Commerce", 1667.90f, -1577.50f, -89.00f, 1812.60f, -1430.80f, 110.90f),
            new MapZone("Conference Center", 1046.10f, -1804.20f, -89.00f, 1323.90f, -1722.20f, 110.90f),
            new MapZone("Conference Center", 1073.20f, -1842.20f, -89.00f, 1323.90f, -1804.20f, 110.90f),
            new MapZone("Cranberry Station", -2007.80f, 56.30f, 0.00f, -1922.00f, 224.70f, 100.00f),
            new MapZone("Creek", 2749.90f, 1937.20f, -89.00f, 2921.60f, 2669.70f, 110.90f),
            new MapZone("Dillimore", 580.70f, -674.80f, -9.50f, 861.00f, -404.70f, 200.00f),
            new MapZone("Doherty", -2270.00f, -324.10f, -0.00f, -1794.90f, -222.50f, 200.00f),
            new MapZone("Doherty", -2173.00f, -222.50f, -0.00f, -1794.90f, 265.20f, 200.00f),
            new MapZone("Downtown", -1982.30f, 744.10f, -6.10f, -1871.70f, 1274.20f, 200.00f),
            new MapZone("Downtown", -1871.70f, 1176.40f, -4.50f, -1620.30f, 1274.20f, 200.00f),
            new MapZone("Downtown", -1700.00f, 744.20f, -6.10f, -1580.00f, 1176.50f, 200.00f),
            new MapZone("Downtown", -1580.00f, 744.20f, -6.10f, -1499.80f, 1025.90f, 200.00f),
            new MapZone("Downtown", -2078.60f, 578.30f, -7.60f, -1499.80f, 744.20f, 200.00f),
            new MapZone("Downtown", -1993.20f, 265.20f, -9.10f, -1794.90f, 578.30f, 200.00f),
            new MapZone("Downtown Los Santos", 1463.90f, -1430.80f, -89.00f, 1724.70f, -1290.80f, 110.90f),
            new MapZone("Downtown Los Santos", 1724.70f, -1430.80f, -89.00f, 1812.60f, -1250.90f, 110.90f),
            new MapZone("Downtown Los Santos", 1463.90f, -1290.80f, -89.00f, 1724.70f, -1150.80f, 110.90f),
            new MapZone("Downtown Los Santos", 1370.80f, -1384.90f, -89.00f, 1463.90f, -1170.80f, 110.90f),
            new MapZone("Downtown Los Santos", 1724.70f, -1250.90f, -89.00f, 1812.60f, -1150.80f, 110.90f),
            new MapZone("Downtown Los Santos", 1370.80f, -1170.80f, -89.00f, 1463.90f, -1130.80f, 110.90f),
            new MapZone("Downtown Los Santos", 1378.30f, -1130.80f, -89.00f, 1463.90f, -1026.30f, 110.90f),
            new MapZone("Downtown Los Santos", 1391.00f, -1026.30f, -89.00f, 1463.90f, -926.90f, 110.90f),
            new MapZone("Downtown Los Santos", 1507.50f, -1385.20f, 110.90f, 1582.50f, -1325.30f, 335.90f),
            new MapZone("East Beach", 2632.80f, -1852.80f, -89.00f, 2959.30f, -1668.10f, 110.90f),
            new MapZone("East Beach", 2632.80f, -1668.10f, -89.00f, 2747.70f, -1393.40f, 110.90f),
            new MapZone("East Beach", 2747.70f, -1668.10f, -89.00f, 2959.30f, -1498.60f, 110.90f),
            new MapZone("East Beach", 2747.70f, -1498.60f, -89.00f, 2959.30f, -1120.00f, 110.90f),
            new MapZone("East Los Santos", 2421.00f, -1628.50f, -89.00f, 2632.80f, -1454.30f, 110.90f),
            new MapZone("East Los Santos", 2222.50f, -1628.50f, -89.00f, 2421.00f, -1494.00f, 110.90f),
            new MapZone("East Los Santos", 2266.20f, -1494.00f, -89.00f, 2381.60f, -1372.00f, 110.90f),
            new MapZone("East Los Santos", 2381.60f, -1494.00f, -89.00f, 2421.00f, -1454.30f, 110.90f),
            new MapZone("East Los Santos", 2281.40f, -1372.00f, -89.00f, 2381.60f, -1135.00f, 110.90f),
            new MapZone("East Los Santos", 2381.60f, -1454.30f, -89.00f, 2462.10f, -1135.00f, 110.90f),
            new MapZone("East Los Santos", 2462.10f, -1454.30f, -89.00f, 2581.70f, -1135.00f, 110.90f),
            new MapZone("Easter Basin", -1794.90f, 249.90f, -9.10f, -1242.90f, 578.30f, 200.00f),
            new MapZone("Easter Basin", -1794.90f, -50.00f, -0.00f, -1499.80f, 249.90f, 200.00f),
            new MapZone("Easter Bay Airport", -1499.80f, -50.00f, -0.00f, -1242.90f, 249.90f, 200.00f),
            new MapZone("Easter Bay Airport", -1794.90f, -730.10f, -3.00f, -1213.90f, -50.00f, 200.00f),
            new MapZone("Easter Bay Airport", -1213.90f, -730.10f, 0.00f, -1132.80f, -50.00f, 200.00f),
            new MapZone("Easter Bay Airport", -1242.90f, -50.00f, 0.00f, -1213.90f, 578.30f, 200.00f),
            new MapZone("Easter Bay Airport", -1213.90f, -50.00f, -4.50f, -947.90f, 578.30f, 200.00f),
            new MapZone("Easter Bay Airport", -1315.40f, -405.30f, 15.40f, -1264.40f, -209.50f, 25.40f),
            new MapZone("Easter Bay Airport", -1354.30f, -287.30f, 15.40f, -1315.40f, -209.50f, 25.40f),
            new MapZone("Easter Bay Airport", -1490.30f, -209.50f, 15.40f, -1264.40f, -148.30f, 25.40f),
            new MapZone("Easter Bay Chemicals", -1132.80f, -768.00f, 0.00f, -956.40f, -578.10f, 200.00f),
            new MapZone("Easter Bay Chemicals", -1132.80f, -787.30f, 0.00f, -956.40f, -768.00f, 200.00f),
            new MapZone("El Castillo del Diablo", -464.50f, 2217.60f, 0.00f, -208.50f, 2580.30f, 200.00f),
            new MapZone("El Castillo del Diablo", -208.50f, 2123.00f, -7.60f, 114.00f, 2337.10f, 200.00f),
            new MapZone("El Castillo del Diablo", -208.50f, 2337.10f, 0.00f, 8.40f, 2487.10f, 200.00f),
            new MapZone("El Corona", 1812.60f, -2179.20f, -89.00f, 1970.60f, -1852.80f, 110.90f),
            new MapZone("El Corona", 1692.60f, -2179.20f, -89.00f, 1812.60f, -1842.20f, 110.90f),
            new MapZone("El Quebrados", -1645.20f, 2498.50f, 0.00f, -1372.10f, 2777.80f, 200.00f),
            new MapZone("Esplanade East", -1620.30f, 1176.50f, -4.50f, -1580.00f, 1274.20f, 200.00f),
            new MapZone("Esplanade East", -1580.00f, 1025.90f, -6.10f, -1499.80f, 1274.20f, 200.00f),
            new MapZone("Esplanade East", -1499.80f, 578.30f, -79.60f, -1339.80f, 1274.20f, 20.30f),
            new MapZone("Esplanade North", -2533.00f, 1358.90f, -4.50f, -1996.60f, 1501.20f, 200.00f),
            new MapZone("Esplanade North", -1996.60f, 1358.90f, -4.50f, -1524.20f, 1592.50f, 200.00f),
            new MapZone("Esplanade North", -1982.30f, 1274.20f, -4.50f, -1524.20f, 1358.90f, 200.00f),
            new MapZone("Fallen Tree", -792.20f, -698.50f, -5.30f, -452.40f, -380.00f, 200.00f),
            new MapZone("Fallow Bridge", 434.30f, 366.50f, 0.00f, 603.00f, 555.60f, 200.00f),
            new MapZone("Fern Ridge", 508.10f, -139.20f, 0.00f, 1306.60f, 119.50f, 200.00f),
            new MapZone("Financial", -1871.70f, 744.10f, -6.10f, -1701.30f, 1176.40f, 300.00f),
            new MapZone("Fisher's Lagoon", 1916.90f, -233.30f, -100.00f, 2131.70f, 13.80f, 200.00f),
            new MapZone("Flint Intersection", -187.70f, -1596.70f, -89.00f, 17.00f, -1276.60f, 110.90f),
            new MapZone("Flint Range", -594.10f, -1648.50f, 0.00f, -187.70f, -1276.60f, 200.00f),
            new MapZone("Fort Carson", -376.20f, 826.30f, -3.00f, 123.70f, 1220.40f, 200.00f),
            new MapZone("Foster Valley", -2270.00f, -430.20f, -0.00f, -2178.60f, -324.10f, 200.00f),
            new MapZone("Foster Valley", -2178.60f, -599.80f, -0.00f, -1794.90f, -324.10f, 200.00f),
            new MapZone("Foster Valley", -2178.60f, -1115.50f, 0.00f, -1794.90f, -599.80f, 200.00f),
            new MapZone("Foster Valley", -2178.60f, -1250.90f, 0.00f, -1794.90f, -1115.50f, 200.00f),
            new MapZone("Frederick Bridge", 2759.20f, 296.50f, 0.00f, 2774.20f, 594.70f, 200.00f),
            new MapZone("Gant Bridge", -2741.40f, 1659.60f, -6.10f, -2616.40f, 2175.10f, 200.00f),
            new MapZone("Gant Bridge", -2741.00f, 1490.40f, -6.10f, -2616.40f, 1659.60f, 200.00f),
            new MapZone("Ganton", 2222.50f, -1852.80f, -89.00f, 2632.80f, -1722.30f, 110.90f),
            new MapZone("Ganton", 2222.50f, -1722.30f, -89.00f, 2632.80f, -1628.50f, 110.90f),
            new MapZone("Garcia", -2411.20f, -222.50f, -0.00f, -2173.00f, 265.20f, 200.00f),
            new MapZone("Garcia", -2395.10f, -222.50f, -5.30f, -2354.00f, -204.70f, 200.00f),
            new MapZone("Garver Bridge", -1339.80f, 828.10f, -89.00f, -1213.90f, 1057.00f, 110.90f),
            new MapZone("Garver Bridge", -1213.90f, 950.00f, -89.00f, -1087.90f, 1178.90f, 110.90f),
            new MapZone("Garver Bridge", -1499.80f, 696.40f, -179.60f, -1339.80f, 925.30f, 20.30f),
            new MapZone("Glen Park", 1812.60f, -1449.60f, -89.00f, 1996.90f, -1350.70f, 110.90f),
            new MapZone("Glen Park", 1812.60f, -1100.80f, -89.00f, 1994.30f, -973.30f, 110.90f),
            new MapZone("Glen Park", 1812.60f, -1350.70f, -89.00f, 2056.80f, -1100.80f, 110.90f),
            new MapZone("Green Palms", 176.50f, 1305.40f, -3.00f, 338.60f, 1520.70f, 200.00f),
            new MapZone("Greenglass College", 964.30f, 1044.60f, -89.00f, 1197.30f, 1203.20f, 110.90f),
            new MapZone("Greenglass College", 964.30f, 930.80f, -89.00f, 1166.50f, 1044.60f, 110.90f),
            new MapZone("Hampton Barns", 603.00f, 264.30f, 0.00f, 761.90f, 366.50f, 200.00f),
            new MapZone("Hankypanky Point", 2576.90f, 62.10f, 0.00f, 2759.20f, 385.50f, 200.00f),
            new MapZone("Harry Gold Parkway", 1777.30f, 863.20f, -89.00f, 1817.30f, 2342.80f, 110.90f),
            new MapZone("Hashbury", -2593.40f, -222.50f, -0.00f, -2411.20f, 54.70f, 200.00f),
            new MapZone("Hilltop Farm", 967.30f, -450.30f, -3.00f, 1176.70f, -217.90f, 200.00f),
            new MapZone("Hunter Quarry", 337.20f, 710.80f, -115.20f, 860.50f, 1031.70f, 203.70f),
            new MapZone("Idlewood", 1812.60f, -1852.80f, -89.00f, 1971.60f, -1742.30f, 110.90f),
            new MapZone("Idlewood", 1812.60f, -1742.30f, -89.00f, 1951.60f, -1602.30f, 110.90f),
            new MapZone("Idlewood", 1951.60f, -1742.30f, -89.00f, 2124.60f, -1602.30f, 110.90f),
            new MapZone("Idlewood", 1812.60f, -1602.30f, -89.00f, 2124.60f, -1449.60f, 110.90f),
            new MapZone("Idlewood", 2124.60f, -1742.30f, -89.00f, 2222.50f, -1494.00f, 110.90f),
            new MapZone("Idlewood", 1971.60f, -1852.80f, -89.00f, 2222.50f, -1742.30f, 110.90f),
            new MapZone("Jefferson", 1996.90f, -1449.60f, -89.00f, 2056.80f, -1350.70f, 110.90f),
            new MapZone("Jefferson", 2124.60f, -1494.00f, -89.00f, 2266.20f, -1449.60f, 110.90f),
            new MapZone("Jefferson", 2056.80f, -1372.00f, -89.00f, 2281.40f, -1210.70f, 110.90f),
            new MapZone("Jefferson", 2056.80f, -1210.70f, -89.00f, 2185.30f, -1126.30f, 110.90f),
            new MapZone("Jefferson", 2185.30f, -1210.70f, -89.00f, 2281.40f, -1154.50f, 110.90f),
            new MapZone("Jefferson", 2056.80f, -1449.60f, -89.00f, 2266.20f, -1372.00f, 110.90f),
            new MapZone("Julius Thruway East", 2623.10f, 943.20f, -89.00f, 2749.90f, 1055.90f, 110.90f),
            new MapZone("Julius Thruway East", 2685.10f, 1055.90f, -89.00f, 2749.90f, 2626.50f, 110.90f),
            new MapZone("Julius Thruway East", 2536.40f, 2442.50f, -89.00f, 2685.10f, 2542.50f, 110.90f),
            new MapZone("Julius Thruway East", 2625.10f, 2202.70f, -89.00f, 2685.10f, 2442.50f, 110.90f),
            new MapZone("Julius Thruway North", 2498.20f, 2542.50f, -89.00f, 2685.10f, 2626.50f, 110.90f),
            new MapZone("Julius Thruway North", 2237.40f, 2542.50f, -89.00f, 2498.20f, 2663.10f, 110.90f),
            new MapZone("Julius Thruway North", 2121.40f, 2508.20f, -89.00f, 2237.40f, 2663.10f, 110.90f),
            new MapZone("Julius Thruway North", 1938.80f, 2508.20f, -89.00f, 2121.40f, 2624.20f, 110.90f),
            new MapZone("Julius Thruway North", 1534.50f, 2433.20f, -89.00f, 1848.40f, 2583.20f, 110.90f),
            new MapZone("Julius Thruway North", 1848.40f, 2478.40f, -89.00f, 1938.80f, 2553.40f, 110.90f),
            new MapZone("Julius Thruway North", 1704.50f, 2342.80f, -89.00f, 1848.40f, 2433.20f, 110.90f),
            new MapZone("Julius Thruway North", 1377.30f, 2433.20f, -89.00f, 1534.50f, 2507.20f, 110.90f),
            new MapZone("Julius Thruway South", 1457.30f, 823.20f, -89.00f, 2377.30f, 863.20f, 110.90f),
            new MapZone("Julius Thruway South", 2377.30f, 788.80f, -89.00f, 2537.30f, 897.90f, 110.90f),
            new MapZone("Julius Thruway West", 1197.30f, 1163.30f, -89.00f, 1236.60f, 2243.20f, 110.90f),
            new MapZone("Julius Thruway West", 1236.60f, 2142.80f, -89.00f, 1297.40f, 2243.20f, 110.90f),
            new MapZone("Juniper Hill", -2533.00f, 578.30f, -7.60f, -2274.10f, 968.30f, 200.00f),
            new MapZone("Juniper Hollow", -2533.00f, 968.30f, -6.10f, -2274.10f, 1358.90f, 200.00f),
            new MapZone("K.A.C.C. Military Fuels", 2498.20f, 2626.50f, -89.00f, 2749.90f, 2861.50f, 110.90f),
            new MapZone("Kincaid Bridge", -1339.80f, 599.20f, -89.00f, -1213.90f, 828.10f, 110.90f),
            new MapZone("Kincaid Bridge", -1213.90f, 721.10f, -89.00f, -1087.90f, 950.00f, 110.90f),
            new MapZone("Kincaid Bridge", -1087.90f, 855.30f, -89.00f, -961.90f, 986.20f, 110.90f),
            new MapZone("King's", -2329.30f, 458.40f, -7.60f, -1993.20f, 578.30f, 200.00f),
            new MapZone("King's", -2411.20f, 265.20f, -9.10f, -1993.20f, 373.50f, 200.00f),
            new MapZone("King's", -2253.50f, 373.50f, -9.10f, -1993.20f, 458.40f, 200.00f),
            new MapZone("LVA Freight Depot", 1457.30f, 863.20f, -89.00f, 1777.40f, 1143.20f, 110.90f),
            new MapZone("LVA Freight Depot", 1375.60f, 919.40f, -89.00f, 1457.30f, 1203.20f, 110.90f),
            new MapZone("LVA Freight Depot", 1277.00f, 1087.60f, -89.00f, 1375.60f, 1203.20f, 110.90f),
            new MapZone("LVA Freight Depot", 1315.30f, 1044.60f, -89.00f, 1375.60f, 1087.60f, 110.90f),
            new MapZone("LVA Freight Depot", 1236.60f, 1163.40f, -89.00f, 1277.00f, 1203.20f, 110.90f),
            new MapZone("Las Barrancas", -926.10f, 1398.70f, -3.00f, -719.20f, 1634.60f, 200.00f),
            new MapZone("Las Brujas", -365.10f, 2123.00f, -3.00f, -208.50f, 2217.60f, 200.00f),
            new MapZone("Las Colinas", 1994.30f, -1100.80f, -89.00f, 2056.80f, -920.80f, 110.90f),
            new MapZone("Las Colinas", 2056.80f, -1126.30f, -89.00f, 2126.80f, -920.80f, 110.90f),
            new MapZone("Las Colinas", 2185.30f, -1154.50f, -89.00f, 2281.40f, -934.40f, 110.90f),
            new MapZone("Las Colinas", 2126.80f, -1126.30f, -89.00f, 2185.30f, -934.40f, 110.90f),
            new MapZone("Las Colinas", 2747.70f, -1120.00f, -89.00f, 2959.30f, -945.00f, 110.90f),
            new MapZone("Las Colinas", 2632.70f, -1135.00f, -89.00f, 2747.70f, -945.00f, 110.90f),
            new MapZone("Las Colinas", 2281.40f, -1135.00f, -89.00f, 2632.70f, -945.00f, 110.90f),
            new MapZone("Las Payasadas", -354.30f, 2580.30f, 2.00f, -133.60f, 2816.80f, 200.00f),
            new MapZone("Las Venturas Airport", 1236.60f, 1203.20f, -89.00f, 1457.30f, 1883.10f, 110.90f),
            new MapZone("Las Venturas Airport", 1457.30f, 1203.20f, -89.00f, 1777.30f, 1883.10f, 110.90f),
            new MapZone("Las Venturas Airport", 1457.30f, 1143.20f, -89.00f, 1777.40f, 1203.20f, 110.90f),
            new MapZone("Las Venturas Airport", 1515.80f, 1586.40f, -12.50f, 1729.90f, 1714.50f, 87.50f),
            new MapZone("Last Dime Motel", 1823.00f, 596.30f, -89.00f, 1997.20f, 823.20f, 110.90f),
            new MapZone("Leafy Hollow", -1166.90f, -1856.00f, 0.00f, -815.60f, -1602.00f, 200.00f),
            new MapZone("Lil' Probe Inn", -90.20f, 1286.80f, -3.00f, 153.80f, 1554.10f, 200.00f),
            new MapZone("Linden Side", 2749.90f, 943.20f, -89.00f, 2923.30f, 1198.90f, 110.90f),
            new MapZone("Linden Station", 2749.90f, 1198.90f, -89.00f, 2923.30f, 1548.90f, 110.90f),
            new MapZone("Linden Station", 2811.20f, 1229.50f, -39.50f, 2861.20f, 1407.50f, 60.40f),
            new MapZone("Little Mexico", 1701.90f, -1842.20f, -89.00f, 1812.60f, -1722.20f, 110.90f),
            new MapZone("Little Mexico", 1758.90f, -1722.20f, -89.00f, 1812.60f, -1577.50f, 110.90f),
            new MapZone("Los Flores", 2581.70f, -1454.30f, -89.00f, 2632.80f, -1393.40f, 110.90f),
            new MapZone("Los Flores", 2581.70f, -1393.40f, -89.00f, 2747.70f, -1135.00f, 110.90f),
            new MapZone("Los Santos International", 1249.60f, -2394.30f, -89.00f, 1852.00f, -2179.20f, 110.90f),
            new MapZone("Los Santos International", 1852.00f, -2394.30f, -89.00f, 2089.00f, -2179.20f, 110.90f),
            new MapZone("Los Santos International", 1382.70f, -2730.80f, -89.00f, 2201.80f, -2394.30f, 110.90f),
            new MapZone("Los Santos International", 1974.60f, -2394.30f, -39.00f, 2089.00f, -2256.50f, 60.90f),
            new MapZone("Los Santos International", 1400.90f, -2669.20f, -39.00f, 2189.80f, -2597.20f, 60.90f),
            new MapZone("Los Santos International", 2051.60f, -2597.20f, -39.00f, 2152.40f, -2394.30f, 60.90f),
            new MapZone("Marina", 647.70f, -1804.20f, -89.00f, 851.40f, -1577.50f, 110.90f),
            new MapZone("Marina", 647.70f, -1577.50f, -89.00f, 807.90f, -1416.20f, 110.90f),
            new MapZone("Marina", 807.90f, -1577.50f, -89.00f, 926.90f, -1416.20f, 110.90f),
            new MapZone("Market", 787.40f, -1416.20f, -89.00f, 1072.60f, -1310.20f, 110.90f),
            new MapZone("Market", 952.60f, -1310.20f, -89.00f, 1072.60f, -1130.80f, 110.90f),
            new MapZone("Market", 1072.60f, -1416.20f, -89.00f, 1370.80f, -1130.80f, 110.90f),
            new MapZone("Market", 926.90f, -1577.50f, -89.00f, 1370.80f, -1416.20f, 110.90f),
            new MapZone("Market Station", 787.40f, -1410.90f, -34.10f, 866.00f, -1310.20f, 65.80f),
            new MapZone("Martin Bridge", -222.10f, 293.30f, 0.00f, -122.10f, 476.40f, 200.00f),
            new MapZone("Missionary Hill", -2994.40f, -811.20f, 0.00f, -2178.60f, -430.20f, 200.00f),
            new MapZone("Montgomery", 1119.50f, 119.50f, -3.00f, 1451.40f, 493.30f, 200.00f),
            new MapZone("Montgomery", 1451.40f, 347.40f, -6.10f, 1582.40f, 420.80f, 200.00f),
            new MapZone("Montgomery Intersection", 1546.60f, 208.10f, 0.00f, 1745.80f, 347.40f, 200.00f),
            new MapZone("Montgomery Intersection", 1582.40f, 347.40f, 0.00f, 1664.60f, 401.70f, 200.00f),
            new MapZone("Mulholland", 1414.00f, -768.00f, -89.00f, 1667.60f, -452.40f, 110.90f),
            new MapZone("Mulholland", 1281.10f, -452.40f, -89.00f, 1641.10f, -290.90f, 110.90f),
            new MapZone("Mulholland", 1269.10f, -768.00f, -89.00f, 1414.00f, -452.40f, 110.90f),
            new MapZone("Mulholland", 1357.00f, -926.90f, -89.00f, 1463.90f, -768.00f, 110.90f),
            new MapZone("Mulholland", 1318.10f, -910.10f, -89.00f, 1357.00f, -768.00f, 110.90f),
            new MapZone("Mulholland", 1169.10f, -910.10f, -89.00f, 1318.10f, -768.00f, 110.90f),
            new MapZone("Mulholland", 768.60f, -954.60f, -89.00f, 952.60f, -860.60f, 110.90f),
            new MapZone("Mulholland", 687.80f, -860.60f, -89.00f, 911.80f, -768.00f, 110.90f),
            new MapZone("Mulholland", 737.50f, -768.00f, -89.00f, 1142.20f, -674.80f, 110.90f),
            new MapZone("Mulholland", 1096.40f, -910.10f, -89.00f, 1169.10f, -768.00f, 110.90f),
            new MapZone("Mulholland", 952.60f, -937.10f, -89.00f, 1096.40f, -860.60f, 110.90f),
            new MapZone("Mulholland", 911.80f, -860.60f, -89.00f, 1096.40f, -768.00f, 110.90f),
            new MapZone("Mulholland", 861.00f, -674.80f, -89.00f, 1156.50f, -600.80f, 110.90f),
            new MapZone("Mulholland Intersection", 1463.90f, -1150.80f, -89.00f, 1812.60f, -768.00f, 110.90f),
            new MapZone("North Rock", 2285.30f, -768.00f, 0.00f, 2770.50f, -269.70f, 200.00f),
            new MapZone("Ocean Docks", 2373.70f, -2697.00f, -89.00f, 2809.20f, -2330.40f, 110.90f),
            new MapZone("Ocean Docks", 2201.80f, -2418.30f, -89.00f, 2324.00f, -2095.00f, 110.90f),
            new MapZone("Ocean Docks", 2324.00f, -2302.30f, -89.00f, 2703.50f, -2145.10f, 110.90f),
            new MapZone("Ocean Docks", 2089.00f, -2394.30f, -89.00f, 2201.80f, -2235.80f, 110.90f),
            new MapZone("Ocean Docks", 2201.80f, -2730.80f, -89.00f, 2324.00f, -2418.30f, 110.90f),
            new MapZone("Ocean Docks", 2703.50f, -2302.30f, -89.00f, 2959.30f, -2126.90f, 110.90f),
            new MapZone("Ocean Docks", 2324.00f, -2145.10f, -89.00f, 2703.50f, -2059.20f, 110.90f),
            new MapZone("Ocean Flats", -2994.40f, 277.40f, -9.10f, -2867.80f, 458.40f, 200.00f),
            new MapZone("Ocean Flats", -2994.40f, -222.50f, -0.00f, -2593.40f, 277.40f, 200.00f),
            new MapZone("Ocean Flats", -2994.40f, -430.20f, -0.00f, -2831.80f, -222.50f, 200.00f),
            new MapZone("Octane Springs", 338.60f, 1228.50f, 0.00f, 664.30f, 1655.00f, 200.00f),
            new MapZone("Old Venturas Strip", 2162.30f, 2012.10f, -89.00f, 2685.10f, 2202.70f, 110.90f),
            new MapZone("Palisades", -2994.40f, 458.40f, -6.10f, -2741.00f, 1339.60f, 200.00f),
            new MapZone("Palomino Creek", 2160.20f, -149.00f, 0.00f, 2576.90f, 228.30f, 200.00f),
            new MapZone("Paradiso", -2741.00f, 793.40f, -6.10f, -2533.00f, 1268.40f, 200.00f),
            new MapZone("Pershing Square", 1440.90f, -1722.20f, -89.00f, 1583.50f, -1577.50f, 110.90f),
            new MapZone("Pilgrim", 2437.30f, 1383.20f, -89.00f, 2624.40f, 1783.20f, 110.90f),
            new MapZone("Pilgrim", 2624.40f, 1383.20f, -89.00f, 2685.10f, 1783.20f, 110.90f),
            new MapZone("Pilson Intersection", 1098.30f, 2243.20f, -89.00f, 1377.30f, 2507.20f, 110.90f),
            new MapZone("Pirates in Men's Pants", 1817.30f, 1469.20f, -89.00f, 2027.40f, 1703.20f, 110.90f),
            new MapZone("Playa del Seville", 2703.50f, -2126.90f, -89.00f, 2959.30f, -1852.80f, 110.90f),
            new MapZone("Prickle Pine", 1534.50f, 2583.20f, -89.00f, 1848.40f, 2863.20f, 110.90f),
            new MapZone("Prickle Pine", 1117.40f, 2507.20f, -89.00f, 1534.50f, 2723.20f, 110.90f),
            new MapZone("Prickle Pine", 1848.40f, 2553.40f, -89.00f, 1938.80f, 2863.20f, 110.90f),
            new MapZone("Prickle Pine", 1938.80f, 2624.20f, -89.00f, 2121.40f, 2861.50f, 110.90f),
            new MapZone("Queens", -2533.00f, 458.40f, 0.00f, -2329.30f, 578.30f, 200.00f),
            new MapZone("Queens", -2593.40f, 54.70f, 0.00f, -2411.20f, 458.40f, 200.00f),
            new MapZone("Queens", -2411.20f, 373.50f, 0.00f, -2253.50f, 458.40f, 200.00f),
            new MapZone("Randolph Industrial Estate", 1558.00f, 596.30f, -89.00f, 1823.00f, 823.20f, 110.90f),
            new MapZone("Redsands East", 1817.30f, 2011.80f, -89.00f, 2106.70f, 2202.70f, 110.90f),
            new MapZone("Redsands East", 1817.30f, 2202.70f, -89.00f, 2011.90f, 2342.80f, 110.90f),
            new MapZone("Redsands East", 1848.40f, 2342.80f, -89.00f, 2011.90f, 2478.40f, 110.90f),
            new MapZone("Redsands West", 1236.60f, 1883.10f, -89.00f, 1777.30f, 2142.80f, 110.90f),
            new MapZone("Redsands West", 1297.40f, 2142.80f, -89.00f, 1777.30f, 2243.20f, 110.90f),
            new MapZone("Redsands West", 1377.30f, 2243.20f, -89.00f, 1704.50f, 2433.20f, 110.90f),
            new MapZone("Redsands West", 1704.50f, 2243.20f, -89.00f, 1777.30f, 2342.80f, 110.90f),
            new MapZone("Regular Tom", -405.70f, 1712.80f, -3.00f, -276.70f, 1892.70f, 200.00f),
            new MapZone("Richman", 647.50f, -1118.20f, -89.00f, 787.40f, -954.60f, 110.90f),
            new MapZone("Richman", 647.50f, -954.60f, -89.00f, 768.60f, -860.60f, 110.90f),
            new MapZone("Richman", 225.10f, -1369.60f, -89.00f, 334.50f, -1292.00f, 110.90f),
            new MapZone("Richman", 225.10f, -1292.00f, -89.00f, 466.20f, -1235.00f, 110.90f),
            new MapZone("Richman", 72.60f, -1404.90f, -89.00f, 225.10f, -1235.00f, 110.90f),
            new MapZone("Richman", 72.60f, -1235.00f, -89.00f, 321.30f, -1008.10f, 110.90f),
            new MapZone("Richman", 321.30f, -1235.00f, -89.00f, 647.50f, -1044.00f, 110.90f),
            new MapZone("Richman", 321.30f, -1044.00f, -89.00f, 647.50f, -860.60f, 110.90f),
            new MapZone("Richman", 321.30f, -860.60f, -89.00f, 687.80f, -768.00f, 110.90f),
            new MapZone("Richman", 321.30f, -768.00f, -89.00f, 700.70f, -674.80f, 110.90f),
            new MapZone("Robada Intersection", -1119.00f, 1178.90f, -89.00f, -862.00f, 1351.40f, 110.90f),
            new MapZone("Roca Escalante", 2237.40f, 2202.70f, -89.00f, 2536.40f, 2542.50f, 110.90f),
            new MapZone("Roca Escalante", 2536.40f, 2202.70f, -89.00f, 2625.10f, 2442.50f, 110.90f),
            new MapZone("Rockshore East", 2537.30f, 676.50f, -89.00f, 2902.30f, 943.20f, 110.90f),
            new MapZone("Rockshore West", 1997.20f, 596.30f, -89.00f, 2377.30f, 823.20f, 110.90f),
            new MapZone("Rockshore West", 2377.30f, 596.30f, -89.00f, 2537.30f, 788.80f, 110.90f),
            new MapZone("Rodeo", 72.60f, -1684.60f, -89.00f, 225.10f, -1544.10f, 110.90f),
            new MapZone("Rodeo", 72.60f, -1544.10f, -89.00f, 225.10f, -1404.90f, 110.90f),
            new MapZone("Rodeo", 225.10f, -1684.60f, -89.00f, 312.80f, -1501.90f, 110.90f),
            new MapZone("Rodeo", 225.10f, -1501.90f, -89.00f, 334.50f, -1369.60f, 110.90f),
            new MapZone("Rodeo", 334.50f, -1501.90f, -89.00f, 422.60f, -1406.00f, 110.90f),
            new MapZone("Rodeo", 312.80f, -1684.60f, -89.00f, 422.60f, -1501.90f, 110.90f),
            new MapZone("Rodeo", 422.60f, -1684.60f, -89.00f, 558.00f, -1570.20f, 110.90f),
            new MapZone("Rodeo", 558.00f, -1684.60f, -89.00f, 647.50f, -1384.90f, 110.90f),
            new MapZone("Rodeo", 466.20f, -1570.20f, -89.00f, 558.00f, -1385.00f, 110.90f),
            new MapZone("Rodeo", 422.60f, -1570.20f, -89.00f, 466.20f, -1406.00f, 110.90f),
            new MapZone("Rodeo", 466.20f, -1385.00f, -89.00f, 647.50f, -1235.00f, 110.90f),
            new MapZone("Rodeo", 334.50f, -1406.00f, -89.00f, 466.20f, -1292.00f, 110.90f),
            new MapZone("Royal Casino", 2087.30f, 1383.20f, -89.00f, 2437.30f, 1543.20f, 110.90f),
            new MapZone("San Andreas Sound", 2450.30f, 385.50f, -100.00f, 2759.20f, 562.30f, 200.00f),
            new MapZone("Santa Flora", -2741.00f, 458.40f, -7.60f, -2533.00f, 793.40f, 200.00f),
            new MapZone("Santa Maria Beach", 342.60f, -2173.20f, -89.00f, 647.70f, -1684.60f, 110.90f),
            new MapZone("Santa Maria Beach", 72.60f, -2173.20f, -89.00f, 342.60f, -1684.60f, 110.90f),
            new MapZone("Shady Cabin", -1632.80f, -2263.40f, -3.00f, -1601.30f, -2231.70f, 200.00f),
            new MapZone("Shady Creeks", -1820.60f, -2643.60f, -8.00f, -1226.70f, -1771.60f, 200.00f),
            new MapZone("Shady Creeks", -2030.10f, -2174.80f, -6.10f, -1820.60f, -1771.60f, 200.00f),
            new MapZone("Sobell Rail Yards", 2749.90f, 1548.90f, -89.00f, 2923.30f, 1937.20f, 110.90f),
            new MapZone("Spinybed", 2121.40f, 2663.10f, -89.00f, 2498.20f, 2861.50f, 110.90f),
            new MapZone("Starfish Casino", 2437.30f, 1783.20f, -89.00f, 2685.10f, 2012.10f, 110.90f),
            new MapZone("Starfish Casino", 2437.30f, 1858.10f, -39.00f, 2495.00f, 1970.80f, 60.90f),
            new MapZone("Starfish Casino", 2162.30f, 1883.20f, -89.00f, 2437.30f, 2012.10f, 110.90f),
            new MapZone("Temple", 1252.30f, -1130.80f, -89.00f, 1378.30f, -1026.30f, 110.90f),
            new MapZone("Temple", 1252.30f, -1026.30f, -89.00f, 1391.00f, -926.90f, 110.90f),
            new MapZone("Temple", 1252.30f, -926.90f, -89.00f, 1357.00f, -910.10f, 110.90f),
            new MapZone("Temple", 952.60f, -1130.80f, -89.00f, 1096.40f, -937.10f, 110.90f),
            new MapZone("Temple", 1096.40f, -1130.80f, -89.00f, 1252.30f, -1026.30f, 110.90f),
            new MapZone("Temple", 1096.40f, -1026.30f, -89.00f, 1252.30f, -910.10f, 110.90f),
            new MapZone("The Camel's Toe", 2087.30f, 1203.20f, -89.00f, 2640.40f, 1383.20f, 110.90f),
            new MapZone("The Clown's Pocket", 2162.30f, 1783.20f, -89.00f, 2437.30f, 1883.20f, 110.90f),
            new MapZone("The Emerald Isle", 2011.90f, 2202.70f, -89.00f, 2237.40f, 2508.20f, 110.90f),
            new MapZone("The Farm", -1209.60f, -1317.10f, 114.90f, -908.10f, -787.30f, 251.90f),
            new MapZone("The Four Dragons Casino", 1817.30f, 863.20f, -89.00f, 2027.30f, 1083.20f, 110.90f),
            new MapZone("The High Roller", 1817.30f, 1283.20f, -89.00f, 2027.30f, 1469.20f, 110.90f),
            new MapZone("The Mako Span", 1664.60f, 401.70f, 0.00f, 1785.10f, 567.20f, 200.00f),
            new MapZone("The Panopticon", -947.90f, -304.30f, -1.10f, -319.60f, 327.00f, 200.00f),
            new MapZone("The Pink Swan", 1817.30f, 1083.20f, -89.00f, 2027.30f, 1283.20f, 110.90f),
            new MapZone("The Sherman Dam", -968.70f, 1929.40f, -3.00f, -481.10f, 2155.20f, 200.00f),
            new MapZone("The Strip", 2027.40f, 863.20f, -89.00f, 2087.30f, 1703.20f, 110.90f),
            new MapZone("The Strip", 2106.70f, 1863.20f, -89.00f, 2162.30f, 2202.70f, 110.90f),
            new MapZone("The Strip", 2027.40f, 1783.20f, -89.00f, 2162.30f, 1863.20f, 110.90f),
            new MapZone("The Strip", 2027.40f, 1703.20f, -89.00f, 2137.40f, 1783.20f, 110.90f),
            new MapZone("The Visage", 1817.30f, 1863.20f, -89.00f, 2106.70f, 2011.80f, 110.90f),
            new MapZone("The Visage", 1817.30f, 1703.20f, -89.00f, 2027.40f, 1863.20f, 110.90f),
            new MapZone("Unity Station", 1692.60f, -1971.80f, -20.40f, 1812.60f, -1932.80f, 79.50f),
            new MapZone("Valle Ocultado", -936.60f, 2611.40f, 2.00f, -715.90f, 2847.90f, 200.00f),
            new MapZone("Verdant Bluffs", 930.20f, -2488.40f, -89.00f, 1249.60f, -2006.70f, 110.90f),
            new MapZone("Verdant Bluffs", 1073.20f, -2006.70f, -89.00f, 1249.60f, -1842.20f, 110.90f),
            new MapZone("Verdant Bluffs", 1249.60f, -2179.20f, -89.00f, 1692.60f, -1842.20f, 110.90f),
            new MapZone("Verdant Meadows", 37.00f, 2337.10f, -3.00f, 435.90f, 2677.90f, 200.00f),
            new MapZone("Verona Beach", 647.70f, -2173.20f, -89.00f, 930.20f, -1804.20f, 110.90f),
            new MapZone("Verona Beach", 930.20f, -2006.70f, -89.00f, 1073.20f, -1804.20f, 110.90f),
            new MapZone("Verona Beach", 851.40f, -1804.20f, -89.00f, 1046.10f, -1577.50f, 110.90f),
            new MapZone("Verona Beach", 1161.50f, -1722.20f, -89.00f, 1323.90f, -1577.50f, 110.90f),
            new MapZone("Verona Beach", 1046.10f, -1722.20f, -89.00f, 1161.50f, -1577.50f, 110.90f),
            new MapZone("Vinewood", 787.40f, -1310.20f, -89.00f, 952.60f, -1130.80f, 110.90f),
            new MapZone("Vinewood", 787.40f, -1130.80f, -89.00f, 952.60f, -954.60f, 110.90f),
            new MapZone("Vinewood", 647.50f, -1227.20f, -89.00f, 787.40f, -1118.20f, 110.90f),
            new MapZone("Vinewood", 647.70f, -1416.20f, -89.00f, 787.40f, -1227.20f, 110.90f),
            new MapZone("Whitewood Estates", 883.30f, 1726.20f, -89.00f, 1098.30f, 2507.20f, 110.90f),
            new MapZone("Whitewood Estates", 1098.30f, 1726.20f, -89.00f, 1197.30f, 2243.20f, 110.90f),
            new MapZone("Willowfield", 1970.60f, -2179.20f, -89.00f, 2089.00f, -1852.80f, 110.90f),
            new MapZone("Willowfield", 2089.00f, -2235.80f, -89.00f, 2201.80f, -1989.90f, 110.90f),
            new MapZone("Willowfield", 2089.00f, -1989.90f, -89.00f, 2324.00f, -1852.80f, 110.90f),
            new MapZone("Willowfield", 2201.80f, -2095.00f, -89.00f, 2324.00f, -1989.90f, 110.90f),
            new MapZone("Willowfield", 2541.70f, -1941.40f, -89.00f, 2703.50f, -1852.80f, 110.90f),
            new MapZone("Willowfield", 2324.00f, -2059.20f, -89.00f, 2541.70f, -1852.80f, 110.90f),
            new MapZone("Willowfield", 2541.70f, -2059.20f, -89.00f, 2703.50f, -1941.40f, 110.90f),
            new MapZone("Yellow Bell Station", 1377.40f, 2600.40f, -21.90f, 1492.40f, 2687.30f, 78.00f),
            new MapZone("Los Santos", 44.60f, -2892.90f, -242.90f, 2997.00f, -768.00f, 900.00f, true),
            new MapZone("Las Venturas", 869.40f, 596.30f, -242.90f, 2997.00f, 2993.80f, 900.00f, true),
            new MapZone("Bone County", -480.50f, 596.30f, -242.90f, 869.40f, 2993.80f, 900.00f, true),
            new MapZone("Tierra Robada", -2997.40f, 1659.60f, -242.90f, -480.50f, 2993.80f, 900.00f, true),
            new MapZone("Tierra Robada", -1213.90f, 596.30f, -242.90f, -480.50f, 1659.60f, 900.00f, true),
            new MapZone("San Fierro", -2997.40f, -1115.50f, -242.90f, -1213.90f, 1659.60f, 900.00f, true),
            new MapZone("Red County", -1213.90f, -768.00f, -242.90f, 2997.00f, 596.30f, 900.00f, true),
            new MapZone("Flint County", -1213.90f, -2892.90f, -242.90f, 44.60f, -768.00f, 900.00f, true),
            new MapZone("Whetstone", -2997.40f, -2892.90f, -242.90f, -1213.90f, -1115.50f, 900.00f, true)
        };

        public MapZone(string name, float x, float y, float z, float maxX, float maxY, float maxZ, bool isMainZone = false)
        {
            Name = name;
            Min = new Vector3(x, y, z);
            Max = new Vector3(maxX, maxY, maxZ);
            IsMainZone = isMainZone;
        }

        public string Name { get; }

        public Vector3 Min { get; }

        public Vector3 Max { get; }

        public bool IsMainZone { get; }

        public static MapZone GetZone(BasePlayer player)
        {
            var position = player.Position;
            for (int i = 0; i < _zones.Length; i++)
            {
                if (InZone(position, _zones[i]))
                {
                    return _zones[i];
                }
            }
            return null;
        }

        public static MapZone GetZone(Vector3 position)
        {
            for (int i = 0; i < _zones.Length; i++)
            {
                if (InZone(position, _zones[i]))
                {
                    return _zones[i];
                }
            }
            return null;
        }

        public static bool InZone(Vector3 position, MapZone zone)
        {
            if (position.X < zone.Min.X || position.X > zone.Max.X) return false;
            else if (position.Y < zone.Min.Y || position.Y > zone.Max.Y) return false;
            else if (position.Z < zone.Min.Z || position.Z > zone.Max.Z) return false;
            return true;
        }

    }
}
