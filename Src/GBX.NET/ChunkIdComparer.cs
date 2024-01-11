﻿namespace GBX.NET;

public sealed class ChunkIdComparer : IComparer<IChunk>
{
    public int Compare(IChunk? x, IChunk? y)
    {
        if (x is null || y is null)
        {
            return 0;
        }

        return x.Id.CompareTo(y.Id) + (x is IHeaderChunk ? -1 : 0) + (y is IHeaderChunk ? 1 : 0);
    }
}