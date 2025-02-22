﻿using UnityEngine;

namespace ReGaSLZR.Utils {

    public static class LogUtil
    {

        private const string CONCATENATOR = ": ";

        public static void PrintInfo(Object gameObject, System.Type logger, string message)
        {
            Debug.Log(string.Concat(logger.Name, CONCATENATOR, message), gameObject);
        }

        public static void PrintWarning(Object gameObject, System.Type logger, string message)
        {
            Debug.LogWarning(string.Concat(logger.Name, CONCATENATOR, message), gameObject);
        }

        public static void PrintError(Object gameObject, System.Type logger, string message)
        {
            Debug.LogError(string.Concat(logger.Name, CONCATENATOR, message), gameObject);
        }

        /* 
            no Context / GameObject reference;
            good for non-MonoBehaviour accessors
         */

        public static void PrintInfo(System.Type logger, string message)
        {             
            Debug.Log(string.Concat(logger.Name, CONCATENATOR, message));
        }

        public static void PrintWarning(System.Type logger, string message)
        {
            Debug.LogWarning(string.Concat(logger.Name, CONCATENATOR, message));
        }

        public static void PrintError(System.Type logger, string message)
        {
            Debug.LogError(string.Concat(logger.Name, CONCATENATOR, message));
        }

        public static void PrintInfo(string message)
        {
            Debug.Log(message);
        }

        public static void PrintWarning(string message)
        {
            Debug.LogWarning(message);
        }

        public static void PrintError(string message)
        {
            Debug.LogError(message);
        }

    }

}