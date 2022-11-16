﻿using System.Collections.Generic;

namespace Maple2.Model.Metadata;

public record EnchantScrollTable(IReadOnlyDictionary<int, EnchantScrollMetadata> Entries) : Table;

public record EnchantScrollMetadata(
    int Type,
    short MinLevel,
    short MaxLevel,
    int[] Enchants,
    int[] ItemTypes,
    int[] Rarities);


public record ItemExchangeScrollTable(IReadOnlyDictionary<int, ItemExchangeScrollMetadata> Entries) : Table;

public record ItemExchangeScrollMetadata();


public record ItemRemakeScrollTable(IReadOnlyDictionary<int, ItemRemakeScrollMetadata> Entries) : Table;

public record ItemRemakeScrollMetadata(
    short MinLevel,
    short MaxLevel,
    int[] ItemTypes,
    int[] Rarities);


public record ItemRepackingScrollTable(IReadOnlyDictionary<int, ItemRepackingScrollMetadata> Entries) : Table;

public record ItemRepackingScrollMetadata(
    short MinLevel,
    short MaxLevel,
    int[] ItemTypes,
    int[] Rarities,
    bool IsPet);


public record ItemSocketScrollTable(IReadOnlyDictionary<int, ItemSocketScrollMetadata> Entries) : Table;

public record ItemSocketScrollMetadata(
    short MinLevel,
    short MaxLevel,
    int[] ItemTypes,
    int[] Rarities,
    byte SocketCount,
    int TradableCountDeduction);