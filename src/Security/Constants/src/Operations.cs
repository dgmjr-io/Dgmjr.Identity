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

public record class Operations
{
    // public static IOperations Parse(string s)
    public static Enums.Operations[] GetValues() =>
        Enum.GetValues(typeof(Enums.Operations)).OfType<Enums.Operations>().ToArray();

    public static IOperations[] GetObjects() => GetValues().Select(FromEnum).ToArray();

    public static IOperations FromEnum(Enums.Operations op) =>
        op switch
        {
            Enums.Operations.Create => Create.Instance,
            Enums.Operations.Read => Read.Instance,
            Enums.Operations.Update => Update.Instance,
            Enums.Operations.Delete => Delete.Instance,
            Enums.Operations.All => All.Instance,
            _
                => throw new InvalidEnumArgumentException(
                    nameof(op),
                    (int)op,
                    typeof(Enums.Operations)
                )
        };

    public static IOperations Parse(string s) =>
        s switch
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

    public record class Create : Operations, IOperations
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
        public static string GuidString = MD5.Create()
            .ComputeHash(UriString.ToUTF8Bytes())
            .ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Create;

        byte IIdentifiable<byte>.Id => (byte)Value;
        string IHaveAName.Name => Name;
        string IHaveAShortName.ShortName => ShortName;
        string IHaveADisplayName.DisplayName => DisplayName;

        string IEnumeration.GroupName => GroupName;

        int IEnumeration.Order => Order;

        guid IEnumeration.Guid => new(GuidString);

        Uri IHaveAUri.Uri => new(UriString);

        object IHaveAValue.Value => Value;

        string IHaveADescription.Description => Description;

        object IIdentifiable.Id => Id;

        Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        public FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        public bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();

        public int CompareTo(IOperations? other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other).Value);

        public override int GetHashCode() => Value.GetHashCode();

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other)?.Value);

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other) =>
            Value.CompareTo(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other) =>
            Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other) =>
            Value.Equals(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations, byte, Enums.Operations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        bool IConvertible.ToBoolean(IFormatProvider provider) =>
            (bool)Convert.ChangeType(Value, typeof(bool), provider);

        byte IConvertible.ToByte(IFormatProvider provider) =>
            (byte)Convert.ChangeType(Value, typeof(byte), provider);

        char IConvertible.ToChar(IFormatProvider provider) =>
            (char)Convert.ChangeType(Value, typeof(char), provider);

        datetime IConvertible.ToDateTime(IFormatProvider provider) =>
            (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        decimal IConvertible.ToDecimal(IFormatProvider provider) =>
            (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        double IConvertible.ToDouble(IFormatProvider provider) =>
            (double)((IConvertible)this).ToType(typeof(double), provider);

        short IConvertible.ToInt16(IFormatProvider provider) =>
            (short)((IConvertible)this).ToType(typeof(short), provider);

        int IConvertible.ToInt32(IFormatProvider provider) =>
            (int)((IConvertible)this).ToType(typeof(int), provider);

        long IConvertible.ToInt64(IFormatProvider provider) =>
            (long)((IConvertible)this).ToType(typeof(long), provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) =>
            (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        float IConvertible.ToSingle(IFormatProvider provider) =>
            (float)((IConvertible)this).ToType(typeof(float), provider);

        string IConvertible.ToString(IFormatProvider provider) => DisplayName;

        object IConvertible.ToType(type conversionType, IFormatProvider provider) =>
            Convert.ChangeType(Value, conversionType, provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) =>
            (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) =>
            (uint)((IConvertible)this).ToType(typeof(uint), provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) =>
            (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        int IComparable.CompareTo(object obj) =>
            obj is Enums.Operations op
                ? Value.CompareTo(op)
                : obj is IOperations op2
                    ? Value.CompareTo(((IHaveAValue<Enums.Operations>)op2).Value)
                    : -1;

        public TAttribute? GetCustomAttribute<TAttribute>()
            where TAttribute : Attribute => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public record class Read : Operations, IOperations
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
        public static string GuidString = MD5.Create()
            .ComputeHash(UriString.ToUTF8Bytes())
            .ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Read;

        byte IIdentifiable<byte>.Id => (byte)Value;
        string IHaveAName.Name => Name;
        string IHaveAShortName.ShortName => ShortName;
        string IHaveADisplayName.DisplayName => DisplayName;
        Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        string IEnumeration.GroupName => GroupName;

        int IEnumeration.Order => Order;

        guid IEnumeration.Guid => new(GuidString);

        Uri IHaveAUri.Uri => new(UriString);

        object IHaveAValue.Value => Value;

        string IHaveADescription.Description => Description;

        object IIdentifiable.Id => Id;

        public FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        public bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();

        public int CompareTo(IOperations? other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other).Value);

        public override int GetHashCode() => Value.GetHashCode();

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other)?.Value);

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other) =>
            Value.CompareTo(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other) =>
            Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other) =>
            Value.Equals(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations, byte, Enums.Operations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        bool IConvertible.ToBoolean(IFormatProvider provider) =>
            (bool)Convert.ChangeType(Value, typeof(bool), provider);

        byte IConvertible.ToByte(IFormatProvider provider) =>
            (byte)Convert.ChangeType(Value, typeof(byte), provider);

        char IConvertible.ToChar(IFormatProvider provider) =>
            (char)Convert.ChangeType(Value, typeof(char), provider);

        datetime IConvertible.ToDateTime(IFormatProvider provider) =>
            (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        decimal IConvertible.ToDecimal(IFormatProvider provider) =>
            (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        double IConvertible.ToDouble(IFormatProvider provider) =>
            (double)((IConvertible)this).ToType(typeof(double), provider);

        short IConvertible.ToInt16(IFormatProvider provider) =>
            (short)((IConvertible)this).ToType(typeof(short), provider);

        int IConvertible.ToInt32(IFormatProvider provider) =>
            (int)((IConvertible)this).ToType(typeof(int), provider);

        long IConvertible.ToInt64(IFormatProvider provider) =>
            (long)((IConvertible)this).ToType(typeof(long), provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) =>
            (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        float IConvertible.ToSingle(IFormatProvider provider) =>
            (float)((IConvertible)this).ToType(typeof(float), provider);

        string IConvertible.ToString(IFormatProvider provider) => DisplayName;

        object IConvertible.ToType(type conversionType, IFormatProvider provider) =>
            Convert.ChangeType(Value, conversionType, provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) =>
            (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) =>
            (uint)((IConvertible)this).ToType(typeof(uint), provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) =>
            (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        int IComparable.CompareTo(object obj) =>
            obj is Enums.Operations op
                ? Value.CompareTo(op)
                : obj is IOperations op2
                    ? Value.CompareTo(((IHaveAValue<Enums.Operations>)op2).Value)
                    : -1;

        public TAttribute? GetCustomAttribute<TAttribute>()
            where TAttribute : Attribute => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public record class Update : Operations, IOperations
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
        public static string GuidString = MD5.Create()
            .ComputeHash(UriString.ToUTF8Bytes())
            .ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Update;

        byte IIdentifiable<byte>.Id => (byte)Value;
        string IHaveAName.Name => Name;
        string IHaveAShortName.ShortName => ShortName;
        string IHaveADisplayName.DisplayName => DisplayName;
        Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        string IEnumeration.GroupName => GroupName;

        int IEnumeration.Order => Order;

        guid IEnumeration.Guid => new(GuidString);

        Uri IHaveAUri.Uri => new(UriString);

        object IHaveAValue.Value => Value;

        string IHaveADescription.Description => Description;

        object IIdentifiable.Id => Id;

        public FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        public bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();

        public int CompareTo(IOperations? other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other)?.Value);

        public override int GetHashCode() => Value.GetHashCode();

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other)?.Value);

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other) =>
            Value.CompareTo(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other) =>
            Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other) =>
            Value.Equals(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations, byte, Enums.Operations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        bool IConvertible.ToBoolean(IFormatProvider provider) =>
            (bool)Convert.ChangeType(Value, typeof(bool), provider);

        byte IConvertible.ToByte(IFormatProvider provider) =>
            (byte)Convert.ChangeType(Value, typeof(byte), provider);

        char IConvertible.ToChar(IFormatProvider provider) =>
            (char)Convert.ChangeType(Value, typeof(char), provider);

        datetime IConvertible.ToDateTime(IFormatProvider provider) =>
            (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        decimal IConvertible.ToDecimal(IFormatProvider provider) =>
            (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        double IConvertible.ToDouble(IFormatProvider provider) =>
            (double)((IConvertible)this).ToType(typeof(double), provider);

        short IConvertible.ToInt16(IFormatProvider provider) =>
            (short)((IConvertible)this).ToType(typeof(short), provider);

        int IConvertible.ToInt32(IFormatProvider provider) =>
            (int)((IConvertible)this).ToType(typeof(int), provider);

        long IConvertible.ToInt64(IFormatProvider provider) =>
            (long)((IConvertible)this).ToType(typeof(long), provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) =>
            (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        float IConvertible.ToSingle(IFormatProvider provider) =>
            (float)((IConvertible)this).ToType(typeof(float), provider);

        string IConvertible.ToString(IFormatProvider provider) => DisplayName;

        object IConvertible.ToType(type conversionType, IFormatProvider provider) =>
            Convert.ChangeType(Value, conversionType, provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) =>
            (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) =>
            (uint)((IConvertible)this).ToType(typeof(uint), provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) =>
            (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        int IComparable.CompareTo(object obj) =>
            obj is Enums.Operations op
                ? Value.CompareTo(op)
                : obj is IOperations op2
                    ? Value.CompareTo(((IHaveAValue<Enums.Operations>)op2).Value)
                    : -1;

        public TAttribute? GetCustomAttribute<TAttribute>()
            where TAttribute : Attribute => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public record class Delete : Operations, IOperations
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
        public static string GuidString = MD5.Create()
            .ComputeHash(UriString.ToUTF8Bytes())
            .ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Delete;

        byte IIdentifiable<byte>.Id => (byte)Value;
        string IHaveAName.Name => Name;
        string IHaveAShortName.ShortName => ShortName;
        string IHaveADisplayName.DisplayName => DisplayName;
        Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        string IEnumeration.GroupName => GroupName;

        int IEnumeration.Order => Order;

        guid IEnumeration.Guid => new(GuidString);

        Uri IHaveAUri.Uri => new(UriString);

        object IHaveAValue.Value => Value;

        string IHaveADescription.Description => Description;

        object IIdentifiable.Id => Id;

        public FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        public bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();

        public int CompareTo(IOperations? other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other).Value);

        public override int GetHashCode() => Value.GetHashCode();

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other)?.Value);

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other) =>
            Value.CompareTo(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other) =>
            Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other) =>
            Value.Equals(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations, byte, Enums.Operations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        bool IConvertible.ToBoolean(IFormatProvider provider) =>
            (bool)Convert.ChangeType(Value, typeof(bool), provider);

        byte IConvertible.ToByte(IFormatProvider provider) =>
            (byte)Convert.ChangeType(Value, typeof(byte), provider);

        char IConvertible.ToChar(IFormatProvider provider) =>
            (char)Convert.ChangeType(Value, typeof(char), provider);

        datetime IConvertible.ToDateTime(IFormatProvider provider) =>
            (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        decimal IConvertible.ToDecimal(IFormatProvider provider) =>
            (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        double IConvertible.ToDouble(IFormatProvider provider) =>
            (double)((IConvertible)this).ToType(typeof(double), provider);

        short IConvertible.ToInt16(IFormatProvider provider) =>
            (short)((IConvertible)this).ToType(typeof(short), provider);

        int IConvertible.ToInt32(IFormatProvider provider) =>
            (int)((IConvertible)this).ToType(typeof(int), provider);

        long IConvertible.ToInt64(IFormatProvider provider) =>
            (long)((IConvertible)this).ToType(typeof(long), provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) =>
            (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        float IConvertible.ToSingle(IFormatProvider provider) =>
            (float)((IConvertible)this).ToType(typeof(float), provider);

        string IConvertible.ToString(IFormatProvider provider) => DisplayName;

        object IConvertible.ToType(type conversionType, IFormatProvider provider) =>
            Convert.ChangeType(Value, conversionType, provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) =>
            (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) =>
            (uint)((IConvertible)this).ToType(typeof(uint), provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) =>
            (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        int IComparable.CompareTo(object obj) =>
            obj is Enums.Operations op
                ? Value.CompareTo(op)
                : obj is IOperations op2
                    ? Value.CompareTo(((IHaveAValue<Enums.Operations>)op2).Value)
                    : -1;

        public TAttribute? GetCustomAttribute<TAttribute>()
            where TAttribute : Attribute => FieldInfo.GetCustomAttribute<TAttribute>();
    }

    public record class All : Operations, IOperations
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
        public static string GuidString = MD5.Create()
            .ComputeHash(UriString.ToUTF8Bytes())
            .ToHexString();
        public const TypeCode TypeCode = System.TypeCode.Byte;
        public const Enums.Operations Value = Enums.Operations.Create;

        byte IIdentifiable<byte>.Id => (byte)Value;
        string IHaveAName.Name => Name;
        string IHaveAShortName.ShortName => ShortName;
        string IHaveADisplayName.DisplayName => DisplayName;
        Enums.Operations IHaveAValue<Enums.Operations>.Value => Value;

        string IEnumeration.GroupName => GroupName;

        int IEnumeration.Order => Order;

        guid IEnumeration.Guid => new(GuidString);

        Uri IHaveAUri.Uri => new(UriString);

        object IHaveAValue.Value => Value;

        string IHaveADescription.Description => Description;

        object IIdentifiable.Id => Id;

        public FieldInfo FieldInfo => GetType().GetRuntimeField(Name);

        public bool Equals(IOperations? other) => GetHashCode() == other?.GetHashCode();

        public int CompareTo(IOperations? other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other).Value);

        public override int GetHashCode() => Value.GetHashCode();

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(IEnumeration other) =>
            Value.CompareTo(((IHaveAValue<Enums.Operations>?)other)?.Value);

        int IEnumeration<IOperations, byte, Enums.Operations>.CompareTo(Enums.Operations other) =>
            Value.CompareTo(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(IEnumeration? other) =>
            Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(Enums.Operations other) =>
            Value.Equals(other);

        bool IEnumeration<IOperations, byte, Enums.Operations>.Equals(
            IEnumeration<IOperations, byte, Enums.Operations> other
        ) => Value.Equals(((IHaveAValue<Enums.Operations>?)other)?.Value);

        TypeCode IConvertible.GetTypeCode() => TypeCode;

        bool IConvertible.ToBoolean(IFormatProvider provider) =>
            (bool)Convert.ChangeType(Value, typeof(bool), provider);

        byte IConvertible.ToByte(IFormatProvider provider) =>
            (byte)Convert.ChangeType(Value, typeof(byte), provider);

        char IConvertible.ToChar(IFormatProvider provider) =>
            (char)Convert.ChangeType(Value, typeof(char), provider);

        datetime IConvertible.ToDateTime(IFormatProvider provider) =>
            (datetime)((IConvertible)this).ToType(typeof(datetime), provider);

        decimal IConvertible.ToDecimal(IFormatProvider provider) =>
            (decimal)((IConvertible)this).ToType(typeof(decimal), provider);

        double IConvertible.ToDouble(IFormatProvider provider) =>
            (double)((IConvertible)this).ToType(typeof(double), provider);

        short IConvertible.ToInt16(IFormatProvider provider) =>
            (short)((IConvertible)this).ToType(typeof(short), provider);

        int IConvertible.ToInt32(IFormatProvider provider) =>
            (int)((IConvertible)this).ToType(typeof(int), provider);

        long IConvertible.ToInt64(IFormatProvider provider) =>
            (long)((IConvertible)this).ToType(typeof(long), provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) =>
            (sbyte)((IConvertible)this).ToType(typeof(sbyte), provider);

        float IConvertible.ToSingle(IFormatProvider provider) =>
            (float)((IConvertible)this).ToType(typeof(float), provider);

        string IConvertible.ToString(IFormatProvider provider) => DisplayName;

        object IConvertible.ToType(type conversionType, IFormatProvider provider) =>
            Convert.ChangeType(Value, conversionType, provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) =>
            (ushort)((IConvertible)this).ToType(typeof(ushort), provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) =>
            (uint)((IConvertible)this).ToType(typeof(uint), provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) =>
            (ulong)((IConvertible)this).ToType(typeof(ulong), provider);

        int IComparable.CompareTo(object obj) =>
            obj is Enums.Operations op
                ? Value.CompareTo(op)
                : obj is IOperations op2
                    ? Value.CompareTo(((IHaveAValue<Enums.Operations>)op2).Value)
                    : -1;

        public TAttribute? GetCustomAttribute<TAttribute>()
            where TAttribute : Attribute => FieldInfo.GetCustomAttribute<TAttribute>();
    }
}
