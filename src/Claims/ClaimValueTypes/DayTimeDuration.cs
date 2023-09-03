/*
 * DayTimeDuration.cs
 *
 *   Created: 2023-08-30-01:44:46
 *   Modified: 2023-08-30-01:44:46
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Primitives;

[RegexDto(@"^(?<Negative:string?>\-?)P(?:(?<Days:int?>\d+)?DT)?(?:(?<Hours:int?>\d+)H)?(?:(?<Minutes:int?>\d+)M)?(?:(?<Seconds:int?>\d+)?(?:\.(?<FractionalSeconds:int?>\d+)?S)?)")]
public partial record struct DayTimeDuration
{
    public readonly bool IsNegative => !IsNullOrEmpty(Negative);
    public readonly int Sign => IsNegative ? -1 : 1;

    public static implicit operator duration(DayTimeDuration dtd)
        => duration.FromMilliseconds(new duration(dtd.Days ?? 0,
                dtd.Hours ?? 0,
                dtd.Minutes ?? 0,
                dtd.Seconds ?? 0,
                dtd.FractionalSeconds.HasValue ? dtd.FractionalSeconds.Value / 1000 : 0).TotalMilliseconds * dtd.Sign);

    public static implicit operator string(DayTimeDuration dtd)
        => $"{(dtd.IsNegative ? "-" : "")}P{(dtd.Days.HasValue ? $"{dtd.Days.Value}D" : "")}{(dtd.Hours.HasValue || dtd.Minutes.HasValue || dtd.Seconds.HasValue || dtd.FractionalSeconds.HasValue ? "T" : "")}{(dtd.Hours.HasValue ? $"{dtd.Hours.Value}H" : "")}{(dtd.Minutes.HasValue ? $"{dtd.Minutes.Value}M" : "")}{(dtd.Seconds.HasValue ? $"{dtd.Seconds.Value}" : "")}{(dtd.FractionalSeconds.HasValue ? $".{dtd.FractionalSeconds.Value}" : "")}{(dtd.Seconds.HasValue || dtd.FractionalSeconds.HasValue ? "S" : "")}";
}
