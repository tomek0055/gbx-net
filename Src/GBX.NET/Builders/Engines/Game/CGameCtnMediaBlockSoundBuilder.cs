﻿using GBX.NET.Engines.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GBX.NET.Builders.Engines.Game;

public partial class CGameCtnMediaBlockSoundBuilder : ICGameCtnMediaBlockSoundBuilder
{
    public FileRef? Sound { get; set; }
    public IList<CGameCtnMediaBlockSound.Key>? Keys { get; set; }
    public int PlayCount { get; set; }
    public bool IsLooping { get; set; }

    public CGameCtnMediaBlockSoundBuilder WithSound(FileRef sound)
    {
        Sound = sound;
        return this;
    }

    public CGameCtnMediaBlockSoundBuilder WithKeys(IList<CGameCtnMediaBlockSound.Key> keys)
    {
        Keys = keys;
        return this;
    }

    public CGameCtnMediaBlockSoundBuilder WithKeys(params CGameCtnMediaBlockSound.Key[] keys)
    {
        Keys = keys;
        return this;
    }

    public CGameCtnMediaBlockSoundBuilder WithPlayCount(int playCount)
    {
        PlayCount = playCount;
        return this;
    }

    public CGameCtnMediaBlockSoundBuilder WithLooping(bool loop)
    {
        IsLooping = loop;
        return this;
    }

    public TMSX ForTMSX() => new(this, NewNode());
    public TMU ForTMU() => new(this, NewNode());
    public TMUF ForTMUF() => new(this, NewNode());
    public TM2 ForTM2() => new(this, NewNode());

    internal CGameCtnMediaBlockSound NewNode()
    {
        var node = NodeCacheManager.GetNodeInstance<CGameCtnMediaBlockSound>(0x030A7000);

        node.Sound = Sound ?? new FileRef();
        node.Keys = Keys ?? new List<CGameCtnMediaBlockSound.Key>();
        node.PlayCount = PlayCount;
        node.IsLooping = IsLooping;

        return node;
    }
}
