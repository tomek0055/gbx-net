﻿namespace GBX.NET.Builders;

public interface IBuilderForTM2020<TBuilder, TNode> where TBuilder : IBuilder where TNode : CMwNod
{
    GameBuilder<TBuilder, TNode> ForTM2020();
}
