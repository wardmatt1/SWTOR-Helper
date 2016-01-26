Public Class My_item
    Private _Name As String
    Private _Lvl As Byte
    Private _Type As String
    Private _Subtype As String
    Private _Source As String
    Private _Tier As Byte
    Private _Quality As String
    Private _Price As Integer
    Private _Crewskill As String
    Private _SkillLvl As Integer
    Private _Planet As String
    Private _Icon As Image
    Private _IconName As String
    Public Sub New()
        Items.Add(Me)

    End Sub

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
    Public Property Lvl As Byte
        Get
            Return _Lvl
        End Get
        Set(value As Byte)
            _Lvl = value
        End Set
    End Property
    Public Property Type As String
        Get
            Return _Type
        End Get
        Set(value As String)
            _Type = value
        End Set
    End Property
    Public Property Subtype As String
        Get
            Return _Subtype
        End Get
        Set(value As String)
            _Subtype = value
        End Set
    End Property
    Public Property Tier As Byte
        Get
            Return _Tier
        End Get
        Set(value As Byte)
            _Tier = value
        End Set
    End Property
    Public Property Price As Integer
        Get
            Return _Price
        End Get
        Set(value As Integer)
            _Price = value
        End Set
    End Property
    Public Property Crewskill As String
        Get
            Return _Crewskill
        End Get
        Set(value As String)
            _Crewskill = value
        End Set
    End Property
    Public Property SkillLvl As Integer
        Get
            Return _SkillLvl
        End Get
        Set(value As Integer)
            _SkillLvl = value
        End Set
    End Property
    Public Property Planet As String
        Get
            Return _Planet
        End Get
        Set(value As String)
            _Planet = value
        End Set
    End Property
    Public Property Icon As Image
        Get
            Return _Icon
        End Get
        Set(value As Image)
            _Icon = value
        End Set
    End Property
    Public Property IconName As String
        Get
            Return _IconName
        End Get
        Set(value As String)
            _IconName = value
        End Set
    End Property
    Public Property Quality As String
        Get
            Return _Quality
        End Get
        Set(value As String)
            _Quality = value
        End Set
    End Property
    Public Property Source As String
        Get
            Return _Source
        End Get
        Set(value As String)
            _Source = value
        End Set
    End Property
End Class
