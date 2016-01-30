Public Class My_CrewSkill
    Private _Name As String
    Private _Tiers(9) As Integer
    Private _TiersP(9) As String
    Private _Type As String
    Private _ReqSkillH As String
    Private _ReqSkillM As String
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
    Public Property ReqSkillH As String
        Get
            Return _ReqSkillH
        End Get
        Set(value As String)
            _ReqSkillH = value
        End Set
    End Property
    Public Property ReqSkillM As String
        Get
            Return _ReqSkillM
        End Get
        Set(value As String)
            _ReqSkillM = _ReqSkillM
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
