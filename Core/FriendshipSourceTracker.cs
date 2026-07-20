namespace FriendshipProgressionTweaker.Core;

public static class FriendshipSourceTracker
{
    public static FriendshipSource Current =
        FriendshipSource.Other;


    public static void Set(FriendshipSource source)
    {
        Current = source;
    }


    public static void Reset()
    {
        Current = FriendshipSource.Other;
    }
}