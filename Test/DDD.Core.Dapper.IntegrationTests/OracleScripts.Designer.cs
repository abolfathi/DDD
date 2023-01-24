﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDD.Core.Infrastructure.Data {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OracleScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OracleScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DDD.Core.Infrastructure.Data.OracleScripts", typeof(OracleScripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE 
        ///    usercount NUMBER;
        ///BEGIN
        ///    SELECT COUNT(*) INTO usercount FROM dba_users WHERE username = &apos;TEST&apos;;
        ///    IF usercount &gt; 0 THEN
        ///        EXECUTE IMMEDIATE &apos;DROP USER TEST CASCADE&apos;;
        ///    END IF;
        ///    EXECUTE IMMEDIATE &apos;CREATE USER TEST IDENTIFIED BY dev&apos;;
        ///    EXECUTE IMMEDIATE &apos;GRANT ALL PRIVILEGES TO TEST&apos;;
        ///END;.
        /// </summary>
        internal static string CreateSchema {
            get {
                return ResourceManager.GetString("CreateSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////.
        /// </summary>
        internal static string ExcludeFailedEventStream {
            get {
                return ResourceManager.GetString("ExcludeFailedEventStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --------------------------------------------------------
        ///--  File created - Thursday-March-03-2022  
        ///--------------------------------------------------------
        ///--------------------------------------------------------
        ///--  DDL for Procedure SPCLEARSCHEMA
        ///--------------------------------------------------------
        ///
        ///CREATE OR REPLACE PROCEDURE TEST.SPCLEARSCHEMA AS 
        ///BEGIN
        ///  FOR c IN (SELECT table_name, constraint_name FROM user_constraints WHERE constraint_type = &apos;R&apos;)
        ///  LOOP
        ///    EXECUTE IMMEDIATE (&apos;alter  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FillSchema {
            get {
                return ResourceManager.GetString("FillSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.EventStream(Type, Source, Position, RetryMax, RetryDelays, BlockSize) VALUES (&apos;Person&apos;, &apos;ID&apos;, &apos;7DB3BE36011E7DBBFB2A3A0044745345&apos;, 5, &apos;10,60,120/80&apos;, 50)
        ////																   
        ///INSERT INTO TEST.EventStream(Type, Source, Position, RetryMax, RetryDelays, BlockSize) VALUES (&apos;Person&apos;, &apos;ID&apos;, &apos;D05BDFF763877E677E6B3A0044746810&apos;, 5, &apos;10,60,120/80&apos;, 50)
        ////																   
        ///INSERT INTO TEST.EventStream(Type, Source, Position, RetryMax, RetryDelays, BlockSize) VAL [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FindEventStreams {
            get {
                return ResourceManager.GetString("FindEventStreams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///Insert into TEST.FAILEDEVENTSTREAM (STREAMID,STREAMTYPE,STREAMSOURCE,STREAMPOSITION,EVENTID,EVENTTYPE,EXCEPTIONTIME,EXCEPTIONTYPE,EXCEPTIONMESSAGE,EXCEPTIONSOURCE,EXCEPTIONINFO,BASEEXCEPTIONTYPE,BASEEXCEPTIONMESSAGE,RETRYCOUNT,RETRYMAX,RETRYDELAYS,BLOCKSIZE) values (&apos;2&apos;,&apos;MessageBox&apos;,&apos;COL&apos;,&apos;7A70770A47C11B9E883A08DA0E368663&apos;,&apos;4DDD0AE15118DE7E883B08DA0E368663&apos;,&apos;DDD.Collaboration.Domain.Messages.MessageBoxCreated, DDD.Collaboration.Messages&apos;,to_date(&apos;19/11/21&apos;,&apos;DD/M [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FindFailedEventStreams {
            get {
                return ResourceManager.GetString("FindFailedEventStreams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.COMMAND (COMMANDID, COMMANDTYPE, BODY, BODYFORMAT, RECURRINGEXPRESSION, LASTEXECUTIONTIME, LASTEXECUTIONSTATUS, LASTEXCEPTIONINFO)
        ///VALUES (N&apos;08D9FDD90A9DE8B608025680BF57BB60&apos;, N&apos;DDD.Core.Application.FakeCommand1, DDD.Core.Messages&apos;, &apos;{&quot;Property1&quot;:&quot;dummy&quot;,&quot;Property2&quot;:10}&apos;, N&apos;JSON&apos;, N&apos;* * * * *&apos;, NULL, NULL, NULL)
        ////
        ///INSERT INTO TEST.COMMAND (COMMANDID, COMMANDTYPE, BODY, BODYFORMAT, RECURRINGEXPRESSION, CONTEXT, LASTEXECUTIONTIME, LASTEXECUTIONSTATUS, LA [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FindRecurringCommands {
            get {
                return ResourceManager.GetString("FindRecurringCommands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///Insert into TEST.FAILEDEVENTSTREAM (STREAMID,STREAMTYPE,STREAMSOURCE,STREAMPOSITION,EVENTID,EVENTTYPE,EXCEPTIONTIME,EXCEPTIONTYPE,EXCEPTIONMESSAGE,EXCEPTIONSOURCE,EXCEPTIONINFO,BASEEXCEPTIONTYPE,BASEEXCEPTIONMESSAGE,RETRYCOUNT,RETRYMAX,RETRYDELAYS,BLOCKSIZE) values (&apos;2&apos;,&apos;MessageBox&apos;,&apos;COL&apos;,&apos;7A70770A47C11B9E883A08DA0E368663&apos;,&apos;4DDD0AE15118DE7E883B08DA0E368663&apos;,&apos;DDD.Collaboration.Domain.Messages.MessageBoxCreated, DDD.Collaboration.Messages&apos;,to_date(&apos;19/11/21&apos;,&apos;DD/M [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IncludeFailedEventStream {
            get {
                return ResourceManager.GetString("IncludeFailedEventStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.COMMAND (COMMANDID, COMMANDTYPE, BODY, BODYFORMAT, RECURRINGEXPRESSION, LASTEXECUTIONTIME, LASTEXECUTIONSTATUS, LASTEXCEPTIONINFO)
        ///VALUES (N&apos;7db3be36011e7dbbfb2a3a0044745345&apos;, N&apos;DDD.Core.Application.FakeCommand1, DDD.Core.Messages&apos;, &apos;{&quot;Property1&quot;:&quot;dummy&quot;,&quot;Property2&quot;:10}&apos;, N&apos;JSON&apos;, N&apos;* * * * *&apos;, NULL, NULL, NULL)
        ////
        ///INSERT INTO TEST.COMMAND (COMMANDID, COMMANDTYPE, BODY, BODYFORMAT, RECURRINGEXPRESSION, LASTEXECUTIONTIME, LASTEXECUTIONSTATUS, LASTEXCEPTI [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MarkRecurringCommandAsFailed {
            get {
                return ResourceManager.GetString("MarkRecurringCommandAsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.COMMAND (COMMANDID, COMMANDTYPE, BODY, BODYFORMAT, RECURRINGEXPRESSION, LASTEXECUTIONTIME, LASTEXECUTIONSTATUS, LASTEXCEPTIONINFO)
        ///VALUES (N&apos;7db3be36011e7dbbfb2a3a0044745345&apos;, N&apos;DDD.Core.Application.FakeCommand1, DDD.Core.Messages&apos;, &apos;{&quot;Property1&quot;:&quot;dummy&quot;,&quot;Property2&quot;:10}&apos;, N&apos;JSON&apos;, N&apos;* * * * *&apos;, to_timestamp(&apos;01/01/22 00:00:00,000000000&apos;,&apos;DD/MM/RR HH24:MI:SSXFF&apos;),&apos;F&apos;,&apos;System.TimeoutException: The operation has timed-out.&apos;)
        ////
        ///INSERT INTO TEST.COMMAN [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MarkRecurringCommandAsSuccessful {
            get {
                return ResourceManager.GetString("MarkRecurringCommandAsSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TABLEWITHID (ID) VALUES (1)
        ////
        ///INSERT INTO TABLEWITHID (ID) VALUES (2)
        ////
        ///INSERT INTO TABLEWITHID (ID) VALUES (3)
        ////
        ///INSERT INTO TABLEWITHID (ID) VALUES (4)
        ////.
        /// </summary>
        internal static string NextId_ExistingRows {
            get {
                return ResourceManager.GetString("NextId_ExistingRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////.
        /// </summary>
        internal static string NextId_NoRow {
            get {
                return ResourceManager.GetString("NextId_NoRow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.Event (EventId, EventType, OccurredOn, Body, BodyFormat, StreamId, StreamType, StreamSource, IssuedBy) VALUES (N&apos;08D9FDD90A9DE8B608025680BF57BB60&apos;, N&apos;DDD.Collaboration.Domain.Messages.MessageBoxCreated, DDD.Collaboration.Messages&apos;, TO_TIMESTAMP(N&apos;2021-11-18 10:01:23.5280000&apos;, &apos;YYYY-MM-DD HH24:MI:SS.FF7&apos;), N&apos;{&quot;boxId&quot;:2,&quot;occurredOn&quot;:&quot;2021-11-18T10:01:23.5277314+01:00&quot;}&apos;, N&apos;JSON&apos;, N&apos;2&apos;, N&apos;MessageBox&apos;, N&apos;COL&apos;, N&apos;Dr Maboul&apos;)
        ////
        ///INSERT INTO TEST.Even [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReadEventStream {
            get {
                return ResourceManager.GetString("ReadEventStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.Event (EventId, EventType, OccurredOn, Body, BodyFormat, StreamId, StreamType, StreamSource, IssuedBy) VALUES (N&apos;08D9FDD90A9DE8B608025680BF57BB60&apos;, N&apos;DDD.Collaboration.Domain.Messages.MessageBoxCreated, DDD.Collaboration.Messages&apos;, TO_TIMESTAMP(N&apos;2021-11-18 10:01:23.5280000&apos;, &apos;YYYY-MM-DD HH24:MI:SS.FF7&apos;), N&apos;{&quot;boxId&quot;:2,&quot;occurredOn&quot;:&quot;2021-11-18T10:01:23.5277314+01:00&quot;}&apos;, N&apos;JSON&apos;, N&apos;2&apos;, N&apos;MessageBox&apos;, N&apos;COL&apos;, N&apos;Dr Maboul&apos;)
        ////
        ///INSERT INTO TEST.Even [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReadFailedEventStream {
            get {
                return ResourceManager.GetString("ReadFailedEventStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////.
        /// </summary>
        internal static string RegisterRecurringCommand {
            get {
                return ResourceManager.GetString("RegisterRecurringCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////.
        /// </summary>
        internal static string SubscribeToEventStream {
            get {
                return ResourceManager.GetString("SubscribeToEventStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///INSERT INTO TEST.EventStream(Type, Source, Position, RetryMax, RetryDelays, BlockSize) VALUES (&apos;Person&apos;, &apos;ID&apos;, &apos;7DB3BE36011E7DBBFB2A3A0044745345&apos;, 5, &apos;10,60,120/80&apos;, 50)
        ////																			   
        ///INSERT INTO TEST.EventStream(Type, Source, Position, RetryMax, RetryDelays, BlockSize) VALUES (&apos;Person&apos;, &apos;ID&apos;, &apos;D05BDFF763877E677E6B3A0044746810&apos;, 5, &apos;10,60,120/80&apos;, 50)
        ////																			   
        ///INSERT INTO TEST.EventStream(Type, Source, Position, RetryMax, RetryDelays, BlockSiz [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateEventStreamPosition {
            get {
                return ResourceManager.GetString("UpdateEventStreamPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////
        ///Insert into TEST.FAILEDEVENTSTREAM (STREAMID,STREAMTYPE,STREAMSOURCE,STREAMPOSITION,EVENTID,EVENTTYPE,EXCEPTIONTIME,EXCEPTIONTYPE,EXCEPTIONMESSAGE,EXCEPTIONSOURCE,EXCEPTIONINFO,BASEEXCEPTIONTYPE,BASEEXCEPTIONMESSAGE,RETRYCOUNT,RETRYMAX,RETRYDELAYS,BLOCKSIZE) values (&apos;2&apos;,&apos;MessageBox&apos;,&apos;COL&apos;,&apos;7A70770A47C11B9E883A08DA0E368663&apos;,&apos;4DDD0AE15118DE7E883B08DA0E368663&apos;,&apos;DDD.Collaboration.Domain.Messages.MessageBoxCreated, DDD.Collaboration.Messages&apos;,to_date(&apos;19/11/21&apos;,&apos;DD/M [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateFailedEventStream {
            get {
                return ResourceManager.GetString("UpdateFailedEventStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  SPCLEARSCHEMA();
        ///END;
        ////.
        /// </summary>
        internal static string WriteEvents {
            get {
                return ResourceManager.GetString("WriteEvents", resourceCulture);
            }
        }
    }
}
