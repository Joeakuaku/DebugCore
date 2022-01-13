using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;
using UnityEngine;

//todo: merge into main class?
public class DebugCoreUtil
{
    //Convert parms to strings
    public static string[] ParmsToStrings(ParameterInfo[] argInputParms)
    {
        string[] returnValue = new string[argInputParms.Length];
        for (int i = 0; i < argInputParms.Length; i++)
        {
            returnValue[i] = argInputParms[i].ParameterType.ToString();
        }
        return returnValue;
    }
    public static string[] ParmsToStrings(System.Type[] argInputParms)
    {
        string[] returnValue = new string[argInputParms.Length];
        for (int i = 0; i < argInputParms.Length; i++)
        {
            returnValue[i] = argInputParms[i].ToString();
        }
        return returnValue;
    }
    public static string[] ParmsToStrings(System.Type argInputParm)
    {
        string[] returnValue = new string[1];
        returnValue[0] = argInputParm.ToString();
        return returnValue;
    }

    public static System.Tuple<string, string>[] ParmsNamesToStrings(ParameterInfo[] argInputParms)
    {
        System.Tuple<string, string>[] returnValue = new System.Tuple<string, string>[argInputParms.Length];
        for (int i = 0; i < argInputParms.Length; i++)
        {
            returnValue[i] = new System.Tuple<string, string>(argInputParms[i].Name, argInputParms[i].ParameterType.ToString());
        }
        return returnValue;
    }



    //Convert ConVar data to readable strings
    public static string ConVarDataToString(object argConVarData)
    {
        string returnValue = "";
        string dataType = argConVarData.GetType().ToString();
        if (dataType.Substring((dataType.Length - 2), 2) == "[]")   //arrays
        {
            //todo: find better way to do this
            returnValue += "{ ";
            foreach(object item in (argConVarData as IEnumerable))
            {
                returnValue += item + " | ";
            }
            returnValue = returnValue.Remove(returnValue.Length - 3);
            returnValue += " }";
        }
        else
        {
            returnValue = argConVarData.ToString();
        }
        return returnValue;
    }
}
