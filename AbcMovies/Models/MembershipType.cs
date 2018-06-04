﻿namespace AbcMovies.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYougo = 1;

    }
}