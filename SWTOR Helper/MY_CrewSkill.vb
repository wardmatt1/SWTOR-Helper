Public Class My_CrewSkill
    Private _Name As String
    Private _Tiers(8) As Integer
    Private _TiersP(8) As String
    Private _Type As String
    Sub New(name As String)
        _Name = name
        CrewSkills.Add(_Name, Me)
    End Sub
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
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

    Public Function GetTier(Tier As Integer)
        Return _Tiers(Tier - 1)
    End Function
    Public Sub SetTier(Tier As Integer, value As Integer)
        _Tiers(Tier) = value
    End Sub
    Public Function GetPlanets(Tier As Integer)
        Return _TiersP(Tier - 1)
    End Function
    Public Sub SetPlanets(Tier As Integer, value As String)
        _TiersP(Tier - 1) = value
    End Sub
End Class
