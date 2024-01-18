public static class BackgroundTimer
{
    private static bool[] hasStarted = [false, false, false, false];

    public static bool GetHasStarted(int pos)
    {
        return hasStarted[pos];
    }

    public static void SetHasStarted(int pos)
    {
        hasStarted[pos] = true;
    }

    public static void SetAllFalse()
    {
        for (int i = 0; i < hasStarted.Length; i++)
        {
            hasStarted[i] = false;
        }
    }
    
}
