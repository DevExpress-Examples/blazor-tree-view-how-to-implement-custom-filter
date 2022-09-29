Namespace TreeViewCustomFilter.Data

    Public Class OfficeLocation

        Public Shared ReadOnly Offices As OfficeLocation() = {New OfficeLocation() With {.Name = "Africa", .Id = "1"}, New OfficeLocation() With {.Name = "Ethiopia", .Id = "2", .ParentId = "1"}, New OfficeLocation() With {.Name = "Dire Dawa", .Id = "3", .ParentId = "2"}, New OfficeLocation() With {.Name = "Addis Ababa", .Id = "4", .ParentId = "2"}, New OfficeLocation() With {.Name = "Nigeria", .Id = "5", .ParentId = "1"}, New OfficeLocation() With {.Name = "Lagos", .Id = "6", .ParentId = "5"}, New OfficeLocation() With {.Name = "Kano", .Id = "7", .ParentId = "5"}, New OfficeLocation() With {.Name = "Asia", .Id = "8"}, New OfficeLocation() With {.Name = "China", .Id = "9", .ParentId = "8"}, New OfficeLocation() With {.Name = "Beijing", .Id = "10", .ParentId = "9"}, New OfficeLocation() With {.Name = "Shanghai", .Id = "11", .ParentId = "9"}, New OfficeLocation() With {.Name = "India", .Id = "12", .ParentId = "8"}, New OfficeLocation() With {.Name = "Indianapolis", .Id = "13", .ParentId = "12"}, New OfficeLocation() With {.Name = "New Delhi", .Id = "14", .ParentId = "12"}, New OfficeLocation() With {.Name = "Australia", .Id = "15"}, New OfficeLocation() With {.Name = "Australia", .Id = "16", .ParentId = "15"}, New OfficeLocation() With {.Name = "Canberra", .Id = "17", .ParentId = "16"}, New OfficeLocation() With {.Name = "Melbourne", .Id = "18", .ParentId = "16"}, New OfficeLocation() With {.Name = "Sydney", .Id = "19", .ParentId = "16"}, New OfficeLocation() With {.Name = "Europe", .Id = "20"}, New OfficeLocation() With {.Name = "Germany", .Id = "21", .ParentId = "20"}, New OfficeLocation() With {.Name = "Berlin", .Id = "22", .ParentId = "20"}, New OfficeLocation() With {.Name = "Hamburg", .Id = "23", .ParentId = "20"}, New OfficeLocation() With {.Name = "France", .Id = "24", .ParentId = "20"}, New OfficeLocation() With {.Name = "Paris", .Id = "25", .ParentId = "24"}, New OfficeLocation() With {.Name = "North America", .Id = "26"}, New OfficeLocation() With {.Name = "Mexico", .Id = "27", .ParentId = "26"}, New OfficeLocation() With {.Name = "Mexico City", .Id = "28", .ParentId = "27"}, New OfficeLocation() With {.Name = "United States", .Id = "29", .ParentId = "26"}, New OfficeLocation() With {.Name = "New York", .Id = "30", .ParentId = "29"}, New OfficeLocation() With {.Name = "Washington", .Id = "31", .ParentId = "29"}, New OfficeLocation() With {.Name = "South America", .Id = "32"}, New OfficeLocation() With {.Name = "Brazil", .Id = "33", .ParentId = "32"}, New OfficeLocation() With {.Name = "Brasilia", .Id = "34", .ParentId = "33"}, New OfficeLocation() With {.Name = "Colombia", .Id = "35", .ParentId = "32"}, New OfficeLocation() With {.Name = "Bogota", .Id = "36", .ParentId = "35"}}

        Public Property Id As String

        Public ReadOnly Property CssClass As String
            Get
                Return "itemclass"
            End Get
        End Property

        Public Property ParentId As String

        Public Property Name As String
    End Class
End Namespace
