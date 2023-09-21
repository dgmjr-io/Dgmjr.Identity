/*
 * Operation.cs
 *
 *   Created: 2023-01-03-12:33:03
 *   Modified: 2023-01-03-12:33:04
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Security;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;

using Dgmjr.Enumerations.Abstractions;

using Microsoft.CodeAnalysis;

using Scriban.Parsing;

public static class Operations
{
    // public static IOperations Parse(string s)
    public static Enums.Operations[] GetValues() => Enum.GetValues(typeof(Enums.Operations)).OfType<Enums.Operations>().ToArray();
    public static IOperations[] GetObjects() => GetValues().Select(FromEnum).ToArray();
    public static IOperations FromEnum(Enums.Operations op) => op switch
    {
        Enums.Operations.Create => Create.Instance,
        Enums.Operations.Read => Read.Instance,
        Enums.Operations.Update => Update.Instance,
        Enums.Operations.Delete => Delete.Instance,
        Enums.Operations.All => All.Instance,
        _ => throw new InvalidEnumArgumentException(nameof(op), (int)op, typeof(Enums.Operations))
    };

    public static IOperations Parse(string s) => s switch
    {
        string str when str == nameof(Create) => Create.Instance,
        string str when str == nameof(Read) => Read.Instance,
        string str when str == nameof(Update) => Update.Instance,
        string str when str == nameof(Delete) => Delete.Instance,
        string str when str == nameof(All) => All.Instance,
        string str when str == Create.DisplayName => Create.Instance,
        string str when str == Read.DisplayName => Read.Instance,
        string str when str == Update.DisplayName => Update.Instance,
        string str when str == Delete.DisplayName => Delete.Instance,
        string str when str == All.DisplayName => All.Instance,
        string str when str == Create.Description => Create.Instance,
        string str when str == Read.Description => Read.Instance,
        string str when str == Update.Description => Update.Instance,
        string str when str == Delete.Description => Delete.Instance,
        string str when str == All.Description => All.Instance,
        string str when str == Create.ShortName => Create.Instance,
        string str when str == Read.ShortName => Read.Instance,
        string str when str == Update.ShortName => Update.Instance,
        string str when str == Delete.ShortName => Delete.Instance,
        string str when str == All.ShortName => All.Instance,
        string str when str == Create.UriString => Create.Instance,
        string str when str == Read.UriString => Read.Instance,
        string str when str == Update.UriString => Update.Instance,
        string str when str == Delete.UriString => Delete.Instance,
        string str when str == All.UriString => All.Instance,
        string str when str == Create.GuidString => Create.Instance,
        string str when str == Read.GuidString => Read.Instance,
        string str when str == Update.GuidString => Update.Instance,
        string str when str == Delete.GuidString => Delete.Instance,
        string str when str == All.GuidString => All.Instance,
        _ => throw new InvalidEnumArgumentException(nameof(s), -0, typeof(Enums.Operations))
    };

    public readonly record struct Create : IOperations
    {
        public static IOperations Instance => new Create();
        public const byte Id = (byte)Value;
        public const string Name = "Create";
        public const string ShortName = "C";
        public const string DisplayName = "Create a resource";
        public const string Description = "Create a resource";
        public const string GroupName = nameof(Operations);
        public const string UriString = "https://dgmjr.io/security/constants/operations/create";
        public const int Order = Id;
        public static readonly string GuidString = MD5.Create().ComputeHash(UriString.ToUTF8Bytes()).ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Create;

        readonly byte IIdentifiable<byte>.Id => (byte)Value;
        readonly string IHaveAName.Name => Name;
        readonly string IHaveAShortName.ShortName => ShortName;
        readonly string IHaveADisplayName.DisplayName => DisplayName;
        readonly Enums.Operations IEnumeration<IOperations, byte, Enums.Operations>.Value => Value;

        readonly string IEnumeration.ShortName => ShortName;

        readonly string IEnumeration.DisplayName => DisplayName;

        readonly string IEnumeration.GroupName => GroupName;

        readonly int IEnumeration.Order => Order;

        readonly guid IEnumeration.Guid => new(GuidString);

        readonly Uri IEnumeration.Uri => new(UriString);

        readonly object IHaveAValue.Value => Value;

        readonly string IHaveADescription.Description => Description;

        readonly object IIdentifiable.Id => Id;

        readonly Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        public readonly FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        // public bool Equals(object? other) => other is Operations op ? Equals(op) : false;
        public readonly bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();
        public readonly int CompareTo(IOperations? other) => Value.CompareTo(other.Value);
        public readonly override int GetHashCode() => Value.GetHashCode();

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other)
            => Value.CompareTo(other?.Value);

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other)
            => Value.CompareTo(other);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other)
            => Value.Equals(other?.Value);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations> other)
            => Value.Equals(other?.Value);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other)
            => Value.Equals(other);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations, byte, Enums.Operations> other)
            => Value.Equals(other?.Value);

        // TAttribute? IEnumeration<IOperations, byte, Enums.Operations>.GetCustomAttribute<TAttribute>() where TAttribute : default
        //     => Value.Equals(other?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        readonly bool IConvertible.ToBoolean(IFormatProvider provider)
            => (bool)Convert.ChangeType(Value, typeof(bool), provider);

        readonly byte IConvertible.ToByte(IFormatProvider provider)
            => (byte)Convert.ChangeType(Value, typeof(byte), provider);

        readonly char IConvertible.ToChar(IFormatProvider provider)
            => (char)Convert.ChangeType(Value, typeof(char), provider);

        readonly datetime IConvertible.ToDateTime(IFormatProvider provider)
            => (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        readonly decimal IConvertible.ToDecimal(IFormatProvider provider)
            => (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        readonly double IConvertible.ToDouble(IFormatProvider provider)
            => (double)((IConvertible)this).ToType(typeof(double), provider);

        readonly short IConvertible.ToInt16(IFormatProvider provider)
            => (short)((IConvertible)this).ToType(typeof(short), provider);

        readonly int IConvertible.ToInt32(IFormatProvider provider)
            => (int)((IConvertible)this).ToType(typeof(int), provider);

        readonly long IConvertible.ToInt64(IFormatProvider provider)
            => (long)((IConvertible)this).ToType(typeof(long), provider);

        readonly sbyte IConvertible.ToSByte(IFormatProvider provider)
            => (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        readonly float IConvertible.ToSingle(IFormatProvider provider)
            => (float)((IConvertible)this).ToType(typeof(float), provider);

        readonly string IConvertible.ToString(IFormatProvider provider)
            => DisplayName;

        readonly object IConvertible.ToType(type conversionType, IFormatProvider provider)
            => Convert.ChangeType(Value, conversionType, provider);

        readonly ushort IConvertible.ToUInt16(IFormatProvider provider)
            => (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        readonly uint IConvertible.ToUInt32(IFormatProvider provider)
            => (uint)((IConvertible)this).ToType(typeof(uint), provider);

        readonly ulong IConvertible.ToUInt64(IFormatProvider provider)
            => (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        readonly int IComparable.CompareTo(object obj)
            => obj is Enums.Operations op ? Value.CompareTo(op) : obj is IOperations op2 ? Value.CompareTo(op2.Value) : -1;

        public TAttribute? GetCustomAttribute<TAttribute>() where TAttribute : Attribute
            => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public readonly record struct Read : IOperations
    {
        public static IOperations Instance => new Read();
        public const byte Id = (byte)Value;
        public const string Name = nameof(Read);
        public const string ShortName = "R";
        public const string DisplayName = "Read a resource";
        public const string Description = "Read a resource";
        public const string GroupName = nameof(Operations);
        public const string UriString = "https://dgmjr.io/security/constants/operations/read";
        public const int Order = Id;
        public static readonly string GuidString = MD5.Create().ComputeHash(UriString.ToUTF8Bytes()).ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Read;

        readonly byte IIdentifiable<byte>.Id => (byte)Value;
        readonly string IHaveAName.Name => Name;
        readonly string IHaveAShortName.ShortName => ShortName;
        readonly string IHaveADisplayName.DisplayName => DisplayName;
        readonly Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        readonly Enums.Operations IEnumeration<IOperations, byte, Enums.Operations>.Value => Value;

        readonly string IEnumeration.ShortName => ShortName;

        readonly string IEnumeration.DisplayName => DisplayName;

        readonly string IEnumeration.GroupName => GroupName;

        readonly int IEnumeration.Order => Order;

        readonly guid IEnumeration.Guid => new(GuidString);

        readonly Uri IEnumeration.Uri => new(UriString);

        readonly object IHaveAValue.Value => Value;

        readonly string IHaveADescription.Description => Description;

        readonly object IIdentifiable.Id => Id;

        public readonly FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        // public bool Equals(object? other) => other is Operations op ? Equals(op) : false;
        public readonly bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();
        public readonly int CompareTo(IOperations? other) => Value.CompareTo(other.Value);
        public readonly override int GetHashCode() => Value.GetHashCode();

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other)
            => Value.CompareTo(other?.Value);

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other)
            => Value.CompareTo(other);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other)
            => Value.Equals(other?.Value);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations> other)
            => Value.Equals(other?.Value);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other)
            => Value.Equals(other);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations, byte, Enums.Operations> other)
            => Value.Equals(other?.Value);

        // TAttribute? IEnumeration<IOperations, byte, Enums.Operations>.GetCustomAttribute<TAttribute>() where TAttribute : default
        //     => Value.Equals(other?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        readonly bool IConvertible.ToBoolean(IFormatProvider provider)
            => (bool)Convert.ChangeType(Value, typeof(bool), provider);

        readonly byte IConvertible.ToByte(IFormatProvider provider)
            => (byte)Convert.ChangeType(Value, typeof(byte), provider);

        readonly char IConvertible.ToChar(IFormatProvider provider)
            => (char)Convert.ChangeType(Value, typeof(char), provider);

        readonly datetime IConvertible.ToDateTime(IFormatProvider provider)
            => (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        readonly decimal IConvertible.ToDecimal(IFormatProvider provider)
            => (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        readonly double IConvertible.ToDouble(IFormatProvider provider)
            => (double)((IConvertible)this).ToType(typeof(double), provider);

        readonly short IConvertible.ToInt16(IFormatProvider provider)
            => (short)((IConvertible)this).ToType(typeof(short), provider);

        readonly int IConvertible.ToInt32(IFormatProvider provider)
            => (int)((IConvertible)this).ToType(typeof(int), provider);

        readonly long IConvertible.ToInt64(IFormatProvider provider)
            => (long)((IConvertible)this).ToType(typeof(long), provider);

        readonly sbyte IConvertible.ToSByte(IFormatProvider provider)
            => (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        readonly float IConvertible.ToSingle(IFormatProvider provider)
            => (float)((IConvertible)this).ToType(typeof(float), provider);

        readonly string IConvertible.ToString(IFormatProvider provider)
            => DisplayName;

        readonly object IConvertible.ToType(type conversionType, IFormatProvider provider)
            => Convert.ChangeType(Value, conversionType, provider);

        readonly ushort IConvertible.ToUInt16(IFormatProvider provider)
            => (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        readonly uint IConvertible.ToUInt32(IFormatProvider provider)
            => (uint)((IConvertible)this).ToType(typeof(uint), provider);

        readonly ulong IConvertible.ToUInt64(IFormatProvider provider)
            => (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        readonly int IComparable.CompareTo(object obj)
            => obj is Enums.Operations op ? Value.CompareTo(op) : obj is IOperations op2 ? Value.CompareTo(op2.Value) : -1;

        public TAttribute? GetCustomAttribute<TAttribute>() where TAttribute : Attribute
            => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public readonly record struct Update : IOperations
    {
        public static IOperations Instance => new Update();
        public const byte Id = (byte)Value;
        public const string Name = nameof(Update);
        public const string ShortName = "W";
        public const string DisplayName = "Update an existing resource";
        public const string Description = "Update an existing resource";
        public const string GroupName = nameof(Operations);
        public const string UriString = "https://dgmjr.io/security/constants/operations/update";
        public const int Order = Id;
        public static readonly string GuidString = MD5.Create().ComputeHash(UriString.ToUTF8Bytes()).ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Update;

        readonly byte IIdentifiable<byte>.Id => (byte)Value;
        readonly string IHaveAName.Name => Name;
        readonly string IHaveAShortName.ShortName => ShortName;
        readonly string IHaveADisplayName.DisplayName => DisplayName;
        readonly Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        readonly Enums.Operations IEnumeration<IOperations, byte, Enums.Operations>.Value => Value;

        readonly string IEnumeration.ShortName => ShortName;

        readonly string IEnumeration.DisplayName => DisplayName;

        readonly string IEnumeration.GroupName => GroupName;

        readonly int IEnumeration.Order => Order;

        readonly guid IEnumeration.Guid => new(GuidString);

        readonly Uri IEnumeration.Uri => new(UriString);

        readonly object IHaveAValue.Value => Value;

        readonly string IHaveADescription.Description => Description;

        readonly object IIdentifiable.Id => Id;

        public readonly FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        // public bool Equals(object? other) => other is Operations op ? Equals(op) : false;
        public readonly bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();
        public readonly int CompareTo(IOperations? other) => Value.CompareTo(other.Value);
        public readonly override int GetHashCode() => Value.GetHashCode();

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other)
            => Value.CompareTo(other?.Value);

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other)
            => Value.CompareTo(other);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other)
            => Value.Equals(other?.Value);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations> other)
            => Value.Equals(other?.Value);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other)
            => Value.Equals(other);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations, byte, Enums.Operations> other)
            => Value.Equals(other?.Value);

        // TAttribute? IEnumeration<IOperations, byte, Enums.Operations>.GetCustomAttribute<TAttribute>() where TAttribute : default
        //     => Value.Equals(other?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        readonly bool IConvertible.ToBoolean(IFormatProvider provider)
            => (bool)Convert.ChangeType(Value, typeof(bool), provider);

        readonly byte IConvertible.ToByte(IFormatProvider provider)
            => (byte)Convert.ChangeType(Value, typeof(byte), provider);

        readonly char IConvertible.ToChar(IFormatProvider provider)
            => (char)Convert.ChangeType(Value, typeof(char), provider);

        readonly datetime IConvertible.ToDateTime(IFormatProvider provider)
            => (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        readonly decimal IConvertible.ToDecimal(IFormatProvider provider)
            => (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        readonly double IConvertible.ToDouble(IFormatProvider provider)
            => (double)((IConvertible)this).ToType(typeof(double), provider);

        readonly short IConvertible.ToInt16(IFormatProvider provider)
            => (short)((IConvertible)this).ToType(typeof(short), provider);

        readonly int IConvertible.ToInt32(IFormatProvider provider)
            => (int)((IConvertible)this).ToType(typeof(int), provider);

        readonly long IConvertible.ToInt64(IFormatProvider provider)
            => (long)((IConvertible)this).ToType(typeof(long), provider);

        readonly sbyte IConvertible.ToSByte(IFormatProvider provider)
            => (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        readonly float IConvertible.ToSingle(IFormatProvider provider)
            => (float)((IConvertible)this).ToType(typeof(float), provider);

        readonly string IConvertible.ToString(IFormatProvider provider)
            => DisplayName;

        readonly object IConvertible.ToType(type conversionType, IFormatProvider provider)
            => Convert.ChangeType(Value, conversionType, provider);

        readonly ushort IConvertible.ToUInt16(IFormatProvider provider)
            => (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        readonly uint IConvertible.ToUInt32(IFormatProvider provider)
            => (uint)((IConvertible)this).ToType(typeof(uint), provider);

        readonly ulong IConvertible.ToUInt64(IFormatProvider provider)
            => (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        readonly int IComparable.CompareTo(object obj)
            => obj is Enums.Operations op ? Value.CompareTo(op) : obj is IOperations op2 ? Value.CompareTo(op2.Value) : -1;

        public TAttribute? GetCustomAttribute<TAttribute>() where TAttribute : Attribute
            => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public readonly record struct Delete : IOperations
    {
        public static IOperations Instance => new Delete();
        public const byte Id = (byte)Value;
        public const string Name = nameof(Delete);
        public const string ShortName = "D";
        public const string DisplayName = "Delete an existing resource";
        public const string Description = "Delete an existing resource";
        public const string GroupName = nameof(Operations);
        public const string UriString = "https://dgmjr.io/security/constants/operations/delete";
        public const int Order = Id;
        public static readonly string GuidString = MD5.Create().ComputeHash(UriString.ToUTF8Bytes()).ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Create;

        readonly byte IIdentifiable<byte>.Id => (byte)Value;
        readonly string IHaveAName.Name => Name;
        readonly string IHaveAShortName.ShortName => ShortName;
        readonly string IHaveADisplayName.DisplayName => DisplayName;
        readonly Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        readonly Enums.Operations IEnumeration<IOperations, byte, Enums.Operations>.Value => Value;

        readonly string IEnumeration.ShortName => ShortName;

        readonly string IEnumeration.DisplayName => DisplayName;

        readonly string IEnumeration.GroupName => GroupName;

        readonly int IEnumeration.Order => Order;

        readonly guid IEnumeration.Guid => new(GuidString);

        readonly Uri IEnumeration.Uri => new(UriString);

        readonly object IHaveAValue.Value => Value;

        readonly string IHaveADescription.Description => Description;

        readonly object IIdentifiable.Id => Id;

        public readonly FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        // public bool Equals(object? other) => other is Operations op ? Equals(op) : false;
        public readonly bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();
        public readonly int CompareTo(IOperations? other) => Value.CompareTo(other.Value);
        public readonly override int GetHashCode() => Value.GetHashCode();

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other)
            => Value.CompareTo(other?.Value);

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other)
            => Value.CompareTo(other);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other)
            => Value.Equals(other?.Value);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations> other)
            => Value.Equals(other?.Value);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other)
            => Value.Equals(other);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations, byte, Enums.Operations> other)
            => Value.Equals(other?.Value);

        // TAttribute? IEnumeration<IOperations, byte, Enums.Operations>.GetCustomAttribute<TAttribute>() where TAttribute : default
        //     => Value.Equals(other?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        readonly bool IConvertible.ToBoolean(IFormatProvider provider)
            => (bool)Convert.ChangeType(Value, typeof(bool), provider);

        readonly byte IConvertible.ToByte(IFormatProvider provider)
            => (byte)Convert.ChangeType(Value, typeof(byte), provider);

        readonly char IConvertible.ToChar(IFormatProvider provider)
            => (char)Convert.ChangeType(Value, typeof(char), provider);

        readonly datetime IConvertible.ToDateTime(IFormatProvider provider)
            => (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        readonly decimal IConvertible.ToDecimal(IFormatProvider provider)
            => (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        readonly double IConvertible.ToDouble(IFormatProvider provider)
            => (double)((IConvertible)this).ToType(typeof(double), provider);

        readonly short IConvertible.ToInt16(IFormatProvider provider)
            => (short)((IConvertible)this).ToType(typeof(short), provider);

        readonly int IConvertible.ToInt32(IFormatProvider provider)
            => (int)((IConvertible)this).ToType(typeof(int), provider);

        readonly long IConvertible.ToInt64(IFormatProvider provider)
            => (long)((IConvertible)this).ToType(typeof(long), provider);

        readonly sbyte IConvertible.ToSByte(IFormatProvider provider)
            => (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        readonly float IConvertible.ToSingle(IFormatProvider provider)
            => (float)((IConvertible)this).ToType(typeof(float), provider);

        readonly string IConvertible.ToString(IFormatProvider provider)
            => DisplayName;

        readonly object IConvertible.ToType(type conversionType, IFormatProvider provider)
            => Convert.ChangeType(Value, conversionType, provider);

        readonly ushort IConvertible.ToUInt16(IFormatProvider provider)
            => (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        readonly uint IConvertible.ToUInt32(IFormatProvider provider)
            => (uint)((IConvertible)this).ToType(typeof(uint), provider);

        readonly ulong IConvertible.ToUInt64(IFormatProvider provider)
            => (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        readonly int IComparable.CompareTo(object obj)
            => obj is Enums.Operations op ? Value.CompareTo(op) : obj is IOperations op2 ? Value.CompareTo(op2.Value) : -1;

        public TAttribute? GetCustomAttribute<TAttribute>() where TAttribute : Attribute
            => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public readonly record struct All : IOperations
    {
        public static IOperations Instance => new Delete();
        public const byte Id = (byte)Value;
        public const string Name = nameof(Delete);
        public const string ShortName = "A";
        public const string DisplayName = "Perform any/all operation(s) on a resource";
        public const string Description = "Perform any/all operation(s) on a resource";
        public const string GroupName = nameof(Operations);
        public const string UriString = "https://dgmjr.io/security/constants/operations/all";
        public const int Order = Id;
        public static readonly string GuidString = MD5.Create().ComputeHash(UriString.ToUTF8Bytes()).ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Create;

        readonly byte IIdentifiable<byte>.Id => (byte)Value;
        readonly string IHaveAName.Name => Name;
        readonly string IHaveAShortName.ShortName => ShortName;
        readonly string IHaveADisplayName.DisplayName => DisplayName;
        readonly Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        readonly Enums.Operations IEnumeration<IOperations, byte, Enums.Operations>.Value => Value;

        readonly string IEnumeration.ShortName => ShortName;

        readonly string IEnumeration.DisplayName => DisplayName;

        readonly string IEnumeration.GroupName => GroupName;

        readonly int IEnumeration.Order => Order;

        readonly guid IEnumeration.Guid => new(GuidString);

        readonly Uri IEnumeration.Uri => new(UriString);

        readonly object IHaveAValue.Value => Value;

        readonly string IHaveADescription.Description => Description;

        readonly object IIdentifiable.Id => Id;

        public readonly FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        // public bool Equals(object? other) => other is Operations op ? Equals(op) : false;
        public readonly bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();
        public readonly int CompareTo(IOperations? other) => Value.CompareTo(other.Value);
        public readonly override int GetHashCode() => Value.GetHashCode();

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other)
            => Value.CompareTo(other?.Value);

        readonly int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other)
            => Value.CompareTo(other);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other)
            => Value.Equals(other?.Value);


        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations> other)
            => Value.Equals(other?.Value);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other)
            => Value.Equals(other);

        readonly bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration<IOperations, byte, Enums.Operations> other)
            => Value.Equals(other?.Value);

        // TAttribute? IEnumeration<IOperations, byte, Enums.Operations>.GetCustomAttribute<TAttribute>() where TAttribute : default
        //     => Value.Equals(other?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        readonly bool IConvertible.ToBoolean(IFormatProvider provider)
            => (bool)Convert.ChangeType(Value, typeof(bool), provider);

        readonly byte IConvertible.ToByte(IFormatProvider provider)
            => (byte)Convert.ChangeType(Value, typeof(byte), provider);

        readonly char IConvertible.ToChar(IFormatProvider provider)
            => (char)Convert.ChangeType(Value, typeof(char), provider);

        readonly datetime IConvertible.ToDateTime(IFormatProvider provider)
            => (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        readonly decimal IConvertible.ToDecimal(IFormatProvider provider)
            => (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        readonly double IConvertible.ToDouble(IFormatProvider provider)
            => (double)((IConvertible)this).ToType(typeof(double), provider);

        readonly short IConvertible.ToInt16(IFormatProvider provider)
            => (short)((IConvertible)this).ToType(typeof(short), provider);

        readonly int IConvertible.ToInt32(IFormatProvider provider)
            => (int)((IConvertible)this).ToType(typeof(int), provider);

        readonly long IConvertible.ToInt64(IFormatProvider provider)
            => (long)((IConvertible)this).ToType(typeof(long), provider);

        readonly sbyte IConvertible.ToSByte(IFormatProvider provider)
            => (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        readonly float IConvertible.ToSingle(IFormatProvider provider)
            => (float)((IConvertible)this).ToType(typeof(float), provider);

        readonly string IConvertible.ToString(IFormatProvider provider)
            => DisplayName;

        readonly object IConvertible.ToType(type conversionType, IFormatProvider provider)
            => Convert.ChangeType(Value, conversionType, provider);

        readonly ushort IConvertible.ToUInt16(IFormatProvider provider)
            => (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        readonly uint IConvertible.ToUInt32(IFormatProvider provider)
            => (uint)((IConvertible)this).ToType(typeof(uint), provider);

        readonly ulong IConvertible.ToUInt64(IFormatProvider provider)
            => (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        readonly int IComparable.CompareTo(object obj)
            => obj is Enums.Operations op ? Value.CompareTo(op) : obj is IOperations op2 ? Value.CompareTo(op2.Value) : -1;

        public TAttribute? GetCustomAttribute<TAttribute>() where TAttribute : Attribute
            => FieldInfo.GetCustomAttribute<TAttribute>();
    }
}
