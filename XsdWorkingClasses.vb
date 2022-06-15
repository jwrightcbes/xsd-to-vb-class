 Public Class Element
        Public Property Ref As Boolean
        Public Property ChildOf As String
        Public Property ElementName As String
        Public Property Children As List(Of Element)
        Public Property Attributes As List(Of Attribute)
        Public Property Opt As Boolean
        Public Property Multiple As Boolean
        Public Property Type As String
        Public Property SimpleContentName As String
        Public Property Order As String

        Sub New()
            Ref = False
            ChildOf = String.Empty
            ElementName = String.Empty
            Children = New List(Of Element)
            Attributes = New List(Of Attribute)
            Opt = True
            Multiple = False
            SimpleContentName = String.Empty
            Order = "0"
        End Sub

    End Class

    Public Class Attribute
        Public Property Name As String
        Public Property Type As String

        Sub New()
            Name = String.Empty
            Type = String.Empty
        End Sub
    End Class

    Public Class Child
        Public Property Name As String
        Public Property Type As String

        Sub New()
            Name = String.Empty
            Type = String.Empty
        End Sub
    End Class
