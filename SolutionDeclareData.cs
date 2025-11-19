using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureSolutionAnalyzer;

internal readonly struct SolutionDeclareData(
    string solutionName,
    string categoryNameSpace, 
    string rowIndex, 
    string ingredientType,
    string dustType)
{
    public string SolutionName { get; } = solutionName;
    public string CategoryNameSpace { get; } = categoryNameSpace;
    public string RowIndex { get; } = rowIndex;
    public string IngredientType { get; } = ingredientType;
    public string DustType { get; } = dustType;
}
