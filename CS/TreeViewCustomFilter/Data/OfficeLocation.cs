namespace TreeViewCustomFilter.Data {
    public class OfficeLocation {
        public static readonly OfficeLocation[] Offices = new[] {
            new OfficeLocation(){Name="Africa", Id = "1" },
            new OfficeLocation(){Name="Ethiopia", Id="2", ParentId="1"  },
            new OfficeLocation(){Name="Dire Dawa", Id = "3", ParentId="2"},
            new OfficeLocation(){Name="Addis Ababa", Id="4", ParentId="2"  },
            new OfficeLocation(){Name="Nigeria",Id = "5", ParentId="1"},
            new OfficeLocation(){Name="Lagos",Id = "6", ParentId="5"},
            new OfficeLocation(){Name="Kano",Id = "7", ParentId="5"},
            new OfficeLocation(){Name="Asia",Id = "8"},
            new OfficeLocation(){Name="China",Id = "9", ParentId="8"},
            new OfficeLocation(){Name="Beijing",Id = "10", ParentId="9"},
            new OfficeLocation(){Name="Shanghai",Id = "11", ParentId="9"},
            new OfficeLocation(){Name="India",Id = "12", ParentId="8"},
            new OfficeLocation(){Name="Indianapolis",Id = "13", ParentId="12"},
            new OfficeLocation(){Name="New Delhi",Id = "14", ParentId="12"},
            new OfficeLocation(){Name="Australia",Id = "15" },
            new OfficeLocation(){Name="Australia",Id = "16", ParentId="15"},
            new OfficeLocation(){Name="Canberra",Id = "17", ParentId="16"},
            new OfficeLocation(){Name="Melbourne",Id = "18", ParentId="16"},
            new OfficeLocation(){Name="Sydney",Id = "19", ParentId="16"},
            new OfficeLocation(){Name="Europe",Id = "20" },
            new OfficeLocation(){Name="Germany",Id = "21", ParentId="20"},
            new OfficeLocation(){Name="Berlin",Id = "22", ParentId="20"},
            new OfficeLocation(){Name="Hamburg",Id = "23", ParentId="20"},
            new OfficeLocation(){Name="France", Id="24", ParentId="20"  },
            new OfficeLocation(){Name="Paris",Id = "25", ParentId="24"},
            new OfficeLocation(){Name="North America",Id = "26"},
            new OfficeLocation(){Name="Mexico",Id = "27", ParentId="26"},
            new OfficeLocation(){Name="Mexico City",Id = "28", ParentId="27"},
            new OfficeLocation(){Name="United States",Id = "29", ParentId="26"},
            new OfficeLocation(){Name="New York", Id="30", ParentId="29" },
            new OfficeLocation(){Name="Washington",Id = "31", ParentId="29"},
            new OfficeLocation(){Name="South America",Id = "32" },
            new OfficeLocation(){Name="Brazil",Id = "33", ParentId="32"},
            new OfficeLocation(){Name="Brasilia",Id = "34", ParentId="33"},
            new OfficeLocation(){Name="Colombia",Id = "35", ParentId="32"},
            new OfficeLocation(){Name="Bogota",Id = "36", ParentId="35"}
        };
    
        public string Id { get; set; }
        public string CssClass => "itemclass";
        public string ParentId { get; set; }
        public string Name { get; set; }
    }
}
