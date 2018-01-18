Imports System.Reflection

Module Reflection
  Public Function FindAllDerivedTypes(Of T)() As List(Of Type)
    Return FindAllDerivedTypes(Of T)(Assembly.GetAssembly(GetType(T)))
  End Function

  Public Function FindAllDerivedTypes(Of T)(ByVal assembly As Assembly) As List(Of Type)
    Dim derivedType = GetType(T)
    Return assembly.GetTypes().Where(Function(ft) ft <> derivedType AndAlso derivedType.IsAssignableFrom(ft)).ToList()
  End Function
End Module
