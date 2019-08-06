﻿using System.Xml.Serialization;

namespace HearthDb.Tests
{
    public class Tag
    {
        public void SetValue(HearthDb.CardDefs.Tag tag)
        {
            EnumId = tag.EnumId;
            Name = tag.Name;
            TypeString = tag.TypeString;
            Value = tag.Value;
            InnerValue = tag.LocStringEnUs;
        }

        [XmlAttribute("enumID")]
        public int EnumId { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("type")]
        public string TypeString { get; set; }

        [XmlAttribute("value")]
        public int Value { get; set; }

        [XmlText]
        public string InnerValue { get; set; }

    }
}