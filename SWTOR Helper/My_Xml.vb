Imports System.Xml
Imports System.IO
Module My_Xml
    Public Sub LoadData()
        loadxml("Classes")
        loadxml("CrewSkills")
        loadxml("Items")
    End Sub

    Public Sub loadxml(dir As String)
        Dim filedir As String = Directory.GetCurrentDirectory() & "\" & dir
        For Each xmlfile In My.Computer.FileSystem.GetFiles(filedir)
            If System.IO.Path.GetExtension(xmlfile) = ".xml" Then
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(xmlfile)
                For Each node As XmlNode In xmlDoc.DocumentElement.ChildNodes
                    Select Case node.Name
                        Case "Item_Crafting"
                            Dim item As New My_item()
                            item.Name = My_InnerText("Name", node)
                            item.Type = "Crafting"
                            item.Source = My_InnerText("Source", node)
                            item.Tier = My_InnerText("Tier", node)
                            item.Crewskill = My_InnerText("CrewSkill", node)

                            If item.Source = "Harvesting" Then

                                For Each skill In CrewSkills
                                    If skill.Key = item.Crewskill Then
                                        item.SkillLvl = skill.Value.GetTier(item.Tier)
                                        item.Planet = skill.Value.GetPlanets(item.Tier)
                                    End If

                                Next
                            End If
                            item.Quality = My_InnerText("Quality", node)
                            item.Subtype = My_InnerText("Subtype", node)
                            item.IconName = My_InnerText("Icon", node)
                            Dim imgfile As String = filedir + "\Icons\" + item.IconName
                            Log("Loaded: " & item.Name)
                            If File.Exists(imgfile) Then
                                item.Icon = Image.FromFile(imgfile)
                                Icons.Images.Add(item.Name, item.Icon)
                            Else
                                Log("File missing: " & imgfile)
                            End If
                        Case "Item"

                        Case "CrewSkill"

                            Dim name As String = My_InnerText("Name", node)
                            Dim crew As New My_CrewSkill(name)
                            crew.Type = My_InnerText("Type", node)
                            crew.SetTier(1, My_InnerText("Tier1", node))
                            crew.SetTier(2, My_InnerText("Tier2", node))
                            crew.SetTier(3, My_InnerText("Tier3", node))
                            crew.SetTier(4, My_InnerText("Tier4", node))
                            crew.SetTier(5, My_InnerText("Tier5", node))
                            crew.SetTier(6, My_InnerText("Tier6", node))
                            crew.SetTier(7, My_InnerText("Tier7", node))
                            crew.SetTier(8, My_InnerText("Tier8", node))
                            crew.SetTier(9, My_InnerText("Tier9", node))
                            Select Case crew.Type
                                Case "Gathering"
                                    crew.SetPlanets(1, My_InnerText("Tier1P", node))
                                    crew.SetPlanets(2, My_InnerText("Tier2P", node))
                                    crew.SetPlanets(3, My_InnerText("Tier3P", node))
                                    crew.SetPlanets(4, My_InnerText("Tier4P", node))
                                    crew.SetPlanets(5, My_InnerText("Tier5P", node))
                                    crew.SetPlanets(6, My_InnerText("Tier6P", node))
                                    crew.SetPlanets(7, My_InnerText("Tier7P", node))
                                    crew.SetPlanets(8, My_InnerText("Tier8P", node))
                                    crew.SetPlanets(9, My_InnerText("Tier9P", node))
                                Case "Crafting"
                                    crew.ReqSkillH = My_InnerText("ReqSkillH", node)
                                    crew.ReqSkillM = My_InnerText("ReqSkillM", node)
                                Case "Mission"
                            End Select

                        Case "Class"
                            Dim newclass As New My_Class()
                            newclass.Name = My_InnerText("Name", node)
                            newclass.SetAdvClass(My_InnerText("AdvClass1", node), 1)
                            newclass.SetDiscipline(newclass.GetAdvClass(1), My_InnerText("Disc1", node), 1)
                            newclass.SetDiscipline(newclass.GetAdvClass(1), My_InnerText("Disc2", node), 2)
                            newclass.SetDiscipline(newclass.GetAdvClass(1), My_InnerText("Disc3", node), 3)
                            newclass.SetAdvClass(My_InnerText("AdvClass2", node), 2)

                            newclass.SetDiscipline(newclass.GetAdvClass(2), My_InnerText("Disc4", node), 1)
                            newclass.SetDiscipline(newclass.GetAdvClass(2), My_InnerText("Disc5", node), 2)
                            newclass.SetDiscipline(newclass.GetAdvClass(2), My_InnerText("Disc6", node), 3)
                        Case "Schematic"

                    End Select
                Next
            End If
        Next


    End Sub
    Private Function My_InnerText(xpath As String, node As XmlNode) As String
        For Each cnode As XmlNode In node.ChildNodes
            If cnode.Name = xpath Then
                Return cnode.InnerText
            End If
        Next
        Log("Node Not Found <" & xpath & "> in " & node.OuterXml)
        Return ""
    End Function
End Module
