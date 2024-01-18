public static class BackgroundTimer
{
    private static Dictionary<long, List<bool>> hasStarted = new Dictionary<long, List<bool>>();

    public static bool GetHasStarted(int pos, long userID){
        return hasStarted[userID][pos];
    }

    public static void SetHasStarted(int pos, long userID){
        hasStarted[userID][pos] = true;
    }

    public static void SetAllFalse(long userID){
        if(!hasStarted.ContainsKey(userID)){
            hasStarted.Add(userID, new List<bool> { false, false, false, false });
        }
        for(int i = 0; i < hasStarted[userID].Count; i++){
            hasStarted[userID][i] = false;
        }
    }
    
}
