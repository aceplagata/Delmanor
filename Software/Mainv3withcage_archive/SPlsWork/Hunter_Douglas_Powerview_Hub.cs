using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using UserModule_BASE64;

namespace UserModule_HUNTER_DOUGLAS_POWERVIEW_HUB
{
    public class UserModuleClass_HUNTER_DOUGLAS_POWERVIEW_HUB : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.StringInput FROM_SCENES;
        SplusTcpClient CLIENT;
        StringParameter IP_ADDRESS;
        ushort G_SCENENUMBEROFIDS = 0;
        ushort G_SCENENUMBEROFNAMES = 0;
        ushort G_MULTISCENENUMBEROFIDS = 0;
        ushort G_MULTISCENENUMBEROFNAMES = 0;
        ushort G_GETTINGFIRMWARE = 0;
        short G_CONNECTIONSTATUS = 0;
        short G_SOCKETSTATUS = 0;
        CrestronString [] G_SCENEIDS;
        CrestronString [] G_SCENENAMES;
        CrestronString [] G_MULTISCENEIDS;
        CrestronString [] G_MULTISCENENAMES;
        CrestronString G_FIRMWARE;
        private void SENDCMD (  SplusExecutionContext __context__, CrestronString COMMAND ) 
            { 
            ushort COUNT = 0;
            
            short RES = 0;
            
            CrestronString PACKET;
            PACKET  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 60;
            COUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 61;
            G_CONNECTIONSTATUS = (short) ( Functions.SocketConnectClient( CLIENT , IP_ADDRESS  , (ushort)( 80 ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 62;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SOCKETSTATUS != 2) ) && Functions.TestForTrue ( Functions.BoolToInt ( COUNT < 10 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 63;
                Functions.Delay (  (int) ( 20 ) ) ; 
                __context__.SourceCodeLine = 64;
                COUNT = (ushort) ( (COUNT + 1) ) ; 
                __context__.SourceCodeLine = 62;
                } 
            
            __context__.SourceCodeLine = 67;
            MakeString ( PACKET , "GET {0} HTTP/1.1\r\nHost: {1}\r\nContent-Type: application/json\r\n\r\n", COMMAND , IP_ADDRESS ) ; 
            __context__.SourceCodeLine = 68;
            RES = (short) ( Functions.SocketSend( CLIENT , PACKET ) ) ; 
            __context__.SourceCodeLine = 70;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RES == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 71;
                Trace( "(SendCmd) Sent[{0}][{1:d}]\r\n", COMMAND , (short)RES) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 73;
                Trace( "[ERROR] (SendCmd) UNABLE TO COMMUNICATE WITH HUB!\r\n") ; 
                } 
            
            
            }
            
        private void GETSCENES (  SplusExecutionContext __context__, CrestronString ID ) 
            { 
            CrestronString CMD;
            CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 80;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_FIRMWARE == "1") ) && Functions.TestForTrue ( Functions.BoolToInt (ID != "0") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 81;
                Trace( "(GetScenes) [{0}]\r\n", ID ) ; 
                __context__.SourceCodeLine = 82;
                MakeString ( CMD , "/api/scenes/{0}", ID ) ; 
                __context__.SourceCodeLine = 83;
                SENDCMD (  __context__ , CMD) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 85;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_FIRMWARE == "2") ) && Functions.TestForTrue ( Functions.BoolToInt (ID != "0") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 86;
                    Trace( "(GetScenes) ERROR! Module was unable to fetch all scenes from hub!\r\n") ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 88;
                    Trace( "(GetScenes)\r\n") ; 
                    __context__.SourceCodeLine = 89;
                    SENDCMD (  __context__ , "/api/scenes") ; 
                    } 
                
                } 
            
            
            }
            
        private void GETMULTISCENES (  SplusExecutionContext __context__, CrestronString ID ) 
            { 
            CrestronString CMD;
            CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 97;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_FIRMWARE == "1") ) && Functions.TestForTrue ( Functions.BoolToInt (ID != "0") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 98;
                Trace( "(GetMultiScenes) [{0}]\r\n", ID ) ; 
                __context__.SourceCodeLine = 99;
                MakeString ( CMD , "/api/scenecollections/{0}", ID ) ; 
                __context__.SourceCodeLine = 100;
                SENDCMD (  __context__ , CMD) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 102;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_FIRMWARE == "2") ) && Functions.TestForTrue ( Functions.BoolToInt (ID != "0") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 103;
                    Trace( "(GetMultiScenes) ERROR! Module was unable to fetch all multiroom scenes from hub!\r\n") ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 105;
                    Trace( "(GetMultiScenes)\r\n") ; 
                    __context__.SourceCodeLine = 106;
                    SENDCMD (  __context__ , "/api/scenecollections") ; 
                    } 
                
                } 
            
            
            }
            
        private void GETFIRMWARE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 112;
            Trace( "(GetFirmware)\r\n") ; 
            __context__.SourceCodeLine = 113;
            G_GETTINGFIRMWARE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 114;
            G_FIRMWARE  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 115;
            SENDCMD (  __context__ , "/api/fwversion") ; 
            
            }
            
        private void RECEIVEFIRMWARE (  SplusExecutionContext __context__, CrestronString RET ) 
            { 
            ushort POS = 0;
            
            CrestronString HOLDER;
            HOLDER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 122;
            Trace( "(ReceiveFirmware)\r\n") ; 
            __context__.SourceCodeLine = 124;
            POS = (ushort) ( Functions.Find( "mainProcessor" , RET ) ) ; 
            __context__.SourceCodeLine = 126;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POS == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 127;
                Trace( "(ReceiveFirmware) FAILED!\r\n") ; 
                __context__.SourceCodeLine = 128;
                return ; 
                } 
            
            __context__.SourceCodeLine = 131;
            POS = (ushort) ( Functions.Find( "revision" , RET ) ) ; 
            __context__.SourceCodeLine = 133;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POS == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 134;
                Trace( "(ReceiveFirmware) FAILED!\r\n") ; 
                __context__.SourceCodeLine = 135;
                return ; 
                } 
            
            __context__.SourceCodeLine = 138;
            HOLDER  .UpdateValue ( Functions.Remove ( ":" , RET , POS)  ) ; 
            __context__.SourceCodeLine = 139;
            HOLDER  .UpdateValue ( Functions.Remove ( "," , RET )  ) ; 
            __context__.SourceCodeLine = 141;
            G_FIRMWARE  .UpdateValue ( Functions.Left ( HOLDER ,  (int) ( (Functions.Length( HOLDER ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 143;
            G_GETTINGFIRMWARE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 145;
            Trace( "(ReceiveFirmware) Hub Gen[{0}]\r\n", G_FIRMWARE ) ; 
            __context__.SourceCodeLine = 147;
            GETSCENES (  __context__ , "0") ; 
            
            }
            
        private void EXECUTESCENE (  SplusExecutionContext __context__, CrestronString ID ) 
            { 
            CrestronString CMD;
            CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 153;
            Trace( "(ExecuteScene) [{0}]\r\n", ID ) ; 
            __context__.SourceCodeLine = 155;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FIRMWARE == "1"))  ) ) 
                { 
                __context__.SourceCodeLine = 156;
                MakeString ( CMD , "/api/scenes:sceneid={0}", ID ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 158;
                MakeString ( CMD , "/api/scenes?sceneId={0}", ID ) ; 
                } 
            
            __context__.SourceCodeLine = 161;
            SENDCMD (  __context__ , CMD) ; 
            
            }
            
        private void EXECUTEMULTISCENE (  SplusExecutionContext __context__, CrestronString ID ) 
            { 
            CrestronString CMD;
            CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 167;
            Trace( "(ExecuteMultiScene) [{0}]\r\n", ID ) ; 
            __context__.SourceCodeLine = 169;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FIRMWARE == "1"))  ) ) 
                { 
                __context__.SourceCodeLine = 170;
                MakeString ( CMD , "/api/scenecollections:scenecollectionid={0}", ID ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 172;
                MakeString ( CMD , "/api/scenecollections?sceneCollectionId={0}", ID ) ; 
                } 
            
            __context__.SourceCodeLine = 175;
            SENDCMD (  __context__ , CMD) ; 
            
            }
            
        private void RECEIVEALLNAMES (  SplusExecutionContext __context__, CrestronString DATA , ushort TYPE ) 
            { 
            CrestronString JUNK;
            JUNK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            CrestronString OBJECT;
            OBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            CrestronString SCENEID;
            SCENEID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            ushort IDS = 0;
            
            ushort IDSTART = 0;
            ushort IDEND = 0;
            
            ushort NAMESTART = 0;
            ushort NAMEEND = 0;
            
            
            __context__.SourceCodeLine = 187;
            Trace( "(ReceiveAllNames) Type[{0:d}]\r\n", (short)TYPE) ; 
            __context__.SourceCodeLine = 189;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 190;
                IDS = (ushort) ( G_SCENENUMBEROFNAMES ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 192;
                IDS = (ushort) ( G_MULTISCENENUMBEROFNAMES ) ; 
                } 
            
            __context__.SourceCodeLine = 195;
            JUNK  .UpdateValue ( Functions.Remove ( "Data" , DATA )  ) ; 
            __context__.SourceCodeLine = 197;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "{" , DATA ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 198;
                OBJECT  .UpdateValue ( Functions.Mid ( DATA ,  (int) ( Functions.Find( "{" , DATA ) ) ,  (int) ( (Functions.Find( "}" , DATA ) - Functions.Find( "{" , DATA )) ) )  ) ; 
                __context__.SourceCodeLine = 199;
                JUNK  .UpdateValue ( Functions.Remove ( "}" , DATA )  ) ; 
                __context__.SourceCodeLine = 201;
                IDSTART = (ushort) ( (Functions.Find( "id" , OBJECT ) + 4) ) ; 
                __context__.SourceCodeLine = 202;
                IDEND = (ushort) ( Functions.Find( "," , OBJECT , IDSTART ) ) ; 
                __context__.SourceCodeLine = 203;
                SCENEID  .UpdateValue ( Functions.Mid ( OBJECT ,  (int) ( IDSTART ) ,  (int) ( (IDEND - IDSTART) ) )  ) ; 
                __context__.SourceCodeLine = 205;
                NAMESTART = (ushort) ( (Functions.Find( "name" , OBJECT ) + 7) ) ; 
                __context__.SourceCodeLine = 206;
                NAMEEND = (ushort) ( (Functions.Find( "," , OBJECT , NAMESTART ) - 1) ) ; 
                __context__.SourceCodeLine = 208;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 209;
                    G_SCENENAMES [ IDS ]  .UpdateValue ( Functions.Mid ( OBJECT ,  (int) ( NAMESTART ) ,  (int) ( (NAMEEND - NAMESTART) ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 211;
                    G_MULTISCENENAMES [ IDS ]  .UpdateValue ( Functions.Mid ( OBJECT ,  (int) ( NAMESTART ) ,  (int) ( (NAMEEND - NAMESTART) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 214;
                IDS = (ushort) ( (IDS + 1) ) ; 
                __context__.SourceCodeLine = 197;
                } 
            
            __context__.SourceCodeLine = 217;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 218;
                G_SCENENUMBEROFNAMES = (ushort) ( IDS ) ; 
                __context__.SourceCodeLine = 219;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCENENUMBEROFNAMES != G_SCENENUMBEROFIDS))  ) ) 
                    { 
                    __context__.SourceCodeLine = 220;
                    Trace( "(ReceiveAllNames) Retrieved [{0:d}] of [{1:d}] Scenes!\r\n", (short)G_SCENENUMBEROFNAMES, (short)G_SCENENUMBEROFIDS) ; 
                    __context__.SourceCodeLine = 221;
                    GETSCENES (  __context__ , G_SCENEIDS[ IDS ]) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 223;
                    Trace( "(ReceiveAllNames) All Scenes Retrieved! [{0:d}]\r\n", (short)G_SCENENUMBEROFIDS) ; 
                    __context__.SourceCodeLine = 224;
                    GETMULTISCENES (  __context__ , "0") ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 227;
                G_MULTISCENENUMBEROFNAMES = (ushort) ( IDS ) ; 
                __context__.SourceCodeLine = 228;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_MULTISCENENUMBEROFNAMES != G_MULTISCENENUMBEROFIDS))  ) ) 
                    { 
                    __context__.SourceCodeLine = 229;
                    Trace( "(ReceiveAllNames) Retrieved [{0:d}] of [{1:d}] Multi-Scenes!\r\n", (short)G_MULTISCENENUMBEROFNAMES, (short)G_MULTISCENENUMBEROFIDS) ; 
                    __context__.SourceCodeLine = 230;
                    GETMULTISCENES (  __context__ , G_MULTISCENEIDS[ IDS ]) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 232;
                    Trace( "(ReceiveAllNames) All MultiScenes Retrieved! [{0:d}]\r\n", (short)G_MULTISCENENUMBEROFIDS) ; 
                    } 
                
                } 
            
            
            }
            
        private void RECEIVEALLSCENES (  SplusExecutionContext __context__, CrestronString DATA , ushort TYPE ) 
            { 
            CrestronString SCENEIDSTRING;
            SCENEIDSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10240, this );
            
            CrestronString SCENEID;
            SCENEID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString JUNK;
            JUNK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            ushort IDS = 0;
            
            
            __context__.SourceCodeLine = 243;
            Trace( "(ReceiveAllScenes) Type[{0:d}]\r\n", (short)TYPE) ; 
            __context__.SourceCodeLine = 245;
            IDS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 247;
            JUNK  .UpdateValue ( Functions.Remove ( "[" , DATA )  ) ; 
            __context__.SourceCodeLine = 248;
            SCENEIDSTRING  .UpdateValue ( Functions.Remove ( "]" , DATA )  ) ; 
            __context__.SourceCodeLine = 250;
            do 
                { 
                __context__.SourceCodeLine = 252;
                SCENEID  .UpdateValue ( Functions.Remove ( "," , SCENEIDSTRING )  ) ; 
                __context__.SourceCodeLine = 253;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 254;
                    G_SCENEIDS [ IDS ]  .UpdateValue ( Functions.Left ( SCENEID ,  (int) ( (Functions.Length( SCENEID ) - 1) ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 256;
                    G_MULTISCENEIDS [ IDS ]  .UpdateValue ( Functions.Left ( SCENEID ,  (int) ( (Functions.Length( SCENEID ) - 1) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 259;
                IDS = (ushort) ( (IDS + 1) ) ; 
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( Functions.Find( "," , SCENEIDSTRING ) < 1 )) )); 
            __context__.SourceCodeLine = 262;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "]" , SCENEIDSTRING ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 263;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 264;
                    G_SCENEIDS [ IDS ]  .UpdateValue ( Functions.Left ( SCENEIDSTRING ,  (int) ( (Functions.Length( SCENEIDSTRING ) - 1) ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 266;
                    G_MULTISCENEIDS [ IDS ]  .UpdateValue ( Functions.Left ( SCENEIDSTRING ,  (int) ( (Functions.Length( SCENEIDSTRING ) - 1) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 269;
                IDS = (ushort) ( (IDS + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 272;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 273;
                G_SCENENUMBEROFIDS = (ushort) ( IDS ) ; 
                __context__.SourceCodeLine = 274;
                G_SCENENUMBEROFNAMES = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 275;
                Trace( "(ReceiveAllScenes}} Found [{0:d}] Scenes!\r\n", (short)IDS) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 277;
                G_MULTISCENENUMBEROFIDS = (ushort) ( IDS ) ; 
                __context__.SourceCodeLine = 278;
                G_MULTISCENENUMBEROFNAMES = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 279;
                Trace( "(ReceiveAllScenes) Found [{0:d}] Multi-Scenes!\r\n", (short)IDS) ; 
                } 
            
            __context__.SourceCodeLine = 282;
            RECEIVEALLNAMES (  __context__ , DATA, (ushort)( TYPE )) ; 
            
            }
            
        private CrestronString MATCHNAMES (  SplusExecutionContext __context__, CrestronString ENCODEDNAME , ushort TYPE ) 
            { 
            ushort COUNT = 0;
            
            ushort IDS = 0;
            
            
            __context__.SourceCodeLine = 290;
            IDS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 292;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 293;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)G_SCENENUMBEROFIDS; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( COUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__1) && (COUNT  <= __FN_FOREND_VAL__1) ) : ( (COUNT  <= __FN_FORSTART_VAL__1) && (COUNT  >= __FN_FOREND_VAL__1) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 295;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENCODEDNAME == G_SCENENAMES[ IDS ]))  ) ) 
                        { 
                        __context__.SourceCodeLine = 296;
                        return ( G_SCENEIDS [ IDS ] ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 298;
                        IDS = (ushort) ( (IDS + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 293;
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 303;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)G_MULTISCENENUMBEROFIDS; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( COUNT  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__2) && (COUNT  <= __FN_FOREND_VAL__2) ) : ( (COUNT  <= __FN_FORSTART_VAL__2) && (COUNT  >= __FN_FOREND_VAL__2) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 305;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENCODEDNAME == G_MULTISCENENAMES[ IDS ]))  ) ) 
                        { 
                        __context__.SourceCodeLine = 306;
                        return ( G_MULTISCENEIDS [ IDS ] ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 308;
                        IDS = (ushort) ( (IDS + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 303;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 314;
            return ( "nomatch" ) ; 
            
            }
            
        private CrestronString NAMETOID (  SplusExecutionContext __context__, CrestronString INPUTNAME , ushort TYPE ) 
            { 
            CrestronString ENCODEDINPUTNAME;
            ENCODEDINPUTNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString TEMPINPUT;
            TEMPINPUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString FOUNDID;
            FOUNDID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 323;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTNAME == ""))  ) ) 
                { 
                __context__.SourceCodeLine = 324;
                return ( "Invalid Name" ) ; 
                } 
            
            __context__.SourceCodeLine = 327;
            MakeString ( TEMPINPUT , "{0}", INPUTNAME ) ; 
            __context__.SourceCodeLine = 328;
            ENCODEDINPUTNAME  .UpdateValue ( UserModuleClass_BASE64.GETBASE64 (  __context__ , this , TEMPINPUT)  ) ; 
            __context__.SourceCodeLine = 330;
            Trace( "(NameToID) Input[{0}] Encoded[{1}] Type[{2:d}]\r\n", INPUTNAME , ENCODEDINPUTNAME , (short)TYPE) ; 
            __context__.SourceCodeLine = 332;
            FOUNDID  .UpdateValue ( MATCHNAMES (  __context__ , ENCODEDINPUTNAME, (ushort)( TYPE ))  ) ; 
            __context__.SourceCodeLine = 334;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FOUNDID == "nomatch"))  ) ) 
                { 
                __context__.SourceCodeLine = 335;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 336;
                    Trace( "(NameToID) Unable to Find Scene[{0}]!\r\n", INPUTNAME ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 338;
                    Trace( "(NameToID) Unable to Find Multi-Scene[{0}]!\r\n", INPUTNAME ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 341;
                Trace( "(NameToID) Matched [{0}] to [{1}]\r\n", INPUTNAME , FOUNDID ) ; 
                __context__.SourceCodeLine = 342;
                return ( FOUNDID ) ; 
                } 
            
            __context__.SourceCodeLine = 345;
            return ( "Invalid Name" ) ; 
            
            }
            
        object FROM_SCENES_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString SCENEID;
                SCENEID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
                
                CrestronString SCENE;
                SCENE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
                
                
                __context__.SourceCodeLine = 357;
                SCENE  .UpdateValue ( FROM_SCENES  ) ; 
                __context__.SourceCodeLine = 358;
                SCENEID  .UpdateValue ( NAMETOID (  __context__ , SCENE, (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 360;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCENEID != "Invalid Name"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 361;
                    EXECUTESCENE (  __context__ , SCENEID) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 363;
                    SCENEID  .UpdateValue ( NAMETOID (  __context__ , SCENE, (ushort)( 1 ))  ) ; 
                    __context__.SourceCodeLine = 365;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCENEID != "Invalid Name"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 366;
                        EXECUTEMULTISCENE (  __context__ , SCENEID) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 368;
                        Trace( "(From_Scenes) Refreshing Scenes!\r\n") ; 
                        __context__.SourceCodeLine = 369;
                        GETSCENES (  __context__ , "0") ; 
                        } 
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CLIENT_OnSocketConnect_1 ( Object __Info__ )
    
        { 
        SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
            
            __context__.SourceCodeLine = 376;
            Trace( "(SOCKETCONNECT)\r\n") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SocketInfo__ ); }
        return this;
        
    }
    
object CLIENT_OnSocketDisconnect_2 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 381;
        Trace( "(SOCKETDISCONNECT)\r\n") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENT_OnSocketReceive_3 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        CrestronString RECEIVEDDATA;
        RECEIVEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30720, this );
        
        
        __context__.SourceCodeLine = 388;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_GETTINGFIRMWARE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 389;
            RECEIVEDDATA  .UpdateValue ( Functions.Gather ( "}}}" , CLIENT .  SocketRxBuf , 15000)  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 391;
            RECEIVEDDATA  .UpdateValue ( Functions.Gather ( "}]}" , CLIENT .  SocketRxBuf , 15000)  ) ; 
            } 
        
        __context__.SourceCodeLine = 396;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "sceneIds" , RECEIVEDDATA ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 397;
            RECEIVEALLSCENES (  __context__ , RECEIVEDDATA, (ushort)( 0 )) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 398;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "sceneData" , RECEIVEDDATA ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 399;
                RECEIVEALLNAMES (  __context__ , RECEIVEDDATA, (ushort)( 0 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 400;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "sceneCollectionIds" , RECEIVEDDATA ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 401;
                    RECEIVEALLSCENES (  __context__ , RECEIVEDDATA, (ushort)( 1 )) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 402;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "sceneCollectionData" , RECEIVEDDATA ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 403;
                        RECEIVEALLNAMES (  __context__ , RECEIVEDDATA, (ushort)( 1 )) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 404;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "firmware" , RECEIVEDDATA ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 405;
                            RECEIVEFIRMWARE (  __context__ , RECEIVEDDATA) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 407;
                            Trace( "(SOCKETRECEIVE) Unknown Message Received\r\n") ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            }
        
        __context__.SourceCodeLine = 410;
        Functions.ClearBuffer ( CLIENT .  SocketRxBuf ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENT_OnSocketStatus_4 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 415;
        G_SOCKETSTATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 417;
        Trace( "(SOCKETSTATUS): Status: {0:d}\r\n", (short)G_SOCKETSTATUS) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 429;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 431;
        Trace( "Hunter Douglas PowerView Hub Module, Version 1.5 (09102018)\r\n") ; 
        __context__.SourceCodeLine = 433;
        GETFIRMWARE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_FIRMWARE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    G_SCENEIDS  = new CrestronString[ 513 ];
    for( uint i = 0; i < 513; i++ )
        G_SCENEIDS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SCENENAMES  = new CrestronString[ 513 ];
    for( uint i = 0; i < 513; i++ )
        G_SCENENAMES [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    G_MULTISCENEIDS  = new CrestronString[ 513 ];
    for( uint i = 0; i < 513; i++ )
        G_MULTISCENEIDS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_MULTISCENENAMES  = new CrestronString[ 513 ];
    for( uint i = 0; i < 513; i++ )
        G_MULTISCENENAMES [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    CLIENT  = new SplusTcpClient ( 30720, this );
    
    FROM_SCENES = new Crestron.Logos.SplusObjects.StringInput( FROM_SCENES__AnalogSerialInput__, 64, this );
    m_StringInputList.Add( FROM_SCENES__AnalogSerialInput__, FROM_SCENES );
    
    IP_ADDRESS = new StringParameter( IP_ADDRESS__Parameter__, this );
    m_ParameterList.Add( IP_ADDRESS__Parameter__, IP_ADDRESS );
    
    
    FROM_SCENES.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_SCENES_OnChange_0, false ) );
    CLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( CLIENT_OnSocketConnect_1, false ) );
    CLIENT.OnSocketDisconnect.Add( new SocketHandlerWrapper( CLIENT_OnSocketDisconnect_2, false ) );
    CLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( CLIENT_OnSocketReceive_3, false ) );
    CLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( CLIENT_OnSocketStatus_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_HUNTER_DOUGLAS_POWERVIEW_HUB ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint FROM_SCENES__AnalogSerialInput__ = 0;
const uint IP_ADDRESS__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
