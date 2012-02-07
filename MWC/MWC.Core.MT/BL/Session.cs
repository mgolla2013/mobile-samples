using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MWC.BL {
	public partial class Session : Contracts.BusinessEntityBase {

		[XmlElement("t")]
		public string Title { get; set; }
		[XmlAttribute("st")]
		public DateTime Start { get; set; }
		[XmlAttribute("en")]
		public DateTime End { get; set; }
		[XmlAttribute("r")]
		public string Room { get; set; }
		[XmlAttribute("sn")]
		public string SpeakerNames { get; set; }
		[XmlElement("o")]
		public string Overview { get; set; }

		[XmlElement("sk")]
		[MWC.DL.SQLite.Ignore]
		public List<string> SpeakerKeys { get; set; }
		
		[XmlIgnore]
		[MWC.DL.SQLite.Ignore]
		public List<Speaker> Speakers { get; set; }
		
		/// <summary></summary>
		public string Key { get; set; }

		public Session ()
		{
		}
	}
}