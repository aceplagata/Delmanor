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

namespace UserModule_YAMAHA_RX_A820_COMMAND___FB_PROCESSOR_V1_0
{
    public class UserModuleClass_YAMAHA_RX_A820_COMMAND___FB_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CONNECT;
        Crestron.Logos.SplusObjects.StringInput CMDIN;
        Crestron.Logos.SplusObjects.BufferInput RS232FROMDEV;
        Crestron.Logos.SplusObjects.DigitalInput TUNERISFM;
        Crestron.Logos.SplusObjects.DigitalInput TUNERISAM;
        Crestron.Logos.SplusObjects.AnalogInput TUNERDIRVAL;
        Crestron.Logos.SplusObjects.DigitalOutput CONNECTED;
        Crestron.Logos.SplusObjects.StringOutput RXPROCESSED;
        Crestron.Logos.SplusObjects.StringOutput RS232_TO_DEV;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ZONE_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE5_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE6_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE7_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE8_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE9_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE10_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE11_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE12_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SLEEP_TIMER_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MAIN_VOL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MAIN_CURR_INPUT_AUDIO_TYPE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_DECODER_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_PURE_DIRECT_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_LIP_SYNC_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_STRAIGHT_MODE_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ENHANCER_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SOUND_PROG_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ADAPTIVE_DSP_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_3D_CINEMA_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_EX_DECODER_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_2CHAN_DECODER_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_CURR_HDMI_OUT_CONFIG;
        Crestron.Logos.SplusObjects.StringOutput MAIN_HDMI_PROC_STATE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_HDMI_ASPECT;
        Crestron.Logos.SplusObjects.StringOutput MAIN_HDMI_RES;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SLEEP_TIMER_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_VOL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_STATION;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FM_MODE;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRCHANNELTEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput PANDLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDCURRSTATIONTEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput USBLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput USBLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput USBCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput USBCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput SERVERLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput SERVERCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODUSBCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSXMCURRCHANNELTEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput RHAPLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput AIRPLAYLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput AIRPLAYCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput AIRPLAYCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput AIRPLAYCURRCOMPTEXT;
        Crestron.Logos.SplusObjects.StringOutput AIRPLAY_VOL_TEXT;
        SplusTcpClient CLIENTSOCKET;
        StringParameter CLIENTSOCKETADDRESS;
        UShortParameter CLIENTSOCKETPORT;
        private CrestronString FN_PARSEDELIMITEDTEXT (  SplusExecutionContext __context__, CrestronString SZTEXT , CrestronString SZANCHOR , CrestronString SZDELIMITER , ushort BCASEMATCH ) 
            { 
            ushort NPOS = 0;
            
            ushort NSTART = 0;
            
            ushort NRANGE = 0;
            
            CrestronString SZVALUE;
            SZVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 318;
            NPOS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 319;
            NSTART = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 320;
            NRANGE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 322;
            if ( Functions.TestForTrue  ( ( BCASEMATCH)  ) ) 
                {
                __context__.SourceCodeLine = 322;
                NPOS = (ushort) ( Functions.Find( SZANCHOR , SZTEXT ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 323;
                NPOS = (ushort) ( Functions.FindNoCase( SZANCHOR , SZTEXT ) ) ; 
                }
            
            __context__.SourceCodeLine = 325;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NPOS > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 327;
                NSTART = (ushort) ( (NPOS + Functions.Length( SZANCHOR )) ) ; 
                __context__.SourceCodeLine = 329;
                if ( Functions.TestForTrue  ( ( BCASEMATCH)  ) ) 
                    {
                    __context__.SourceCodeLine = 329;
                    NRANGE = (ushort) ( Functions.Find( SZDELIMITER , SZTEXT , NSTART ) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 330;
                    NRANGE = (ushort) ( Functions.FindNoCase( SZDELIMITER , SZTEXT , NSTART ) ) ; 
                    }
                
                __context__.SourceCodeLine = 332;
                NRANGE = (ushort) ( (NRANGE - NSTART) ) ; 
                __context__.SourceCodeLine = 334;
                SZVALUE  .UpdateValue ( Functions.Mid ( SZTEXT ,  (int) ( NSTART ) ,  (int) ( NRANGE ) )  ) ; 
                __context__.SourceCodeLine = 335;
                return ( SZVALUE ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 337;
                return ( "" ) ; 
                }
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void FN_PARSEMAIN (  SplusExecutionContext __context__, CrestronString MAINDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 347;
            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SLEEP=" , MAINDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 349;
                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                __context__.SourceCodeLine = 350;
                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                __context__.SourceCodeLine = 351;
                MAIN_SLEEP_TIMER_TEXT  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 354;
                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:VOL=" , MAINDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 356;
                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                    __context__.SourceCodeLine = 357;
                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                    __context__.SourceCodeLine = 358;
                    MAIN_VOL_TEXT  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 361;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:AUDSEL=" , MAINDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 363;
                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                        __context__.SourceCodeLine = 364;
                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                        __context__.SourceCodeLine = 365;
                        MAIN_CURR_INPUT_AUDIO_TYPE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 368;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:DECODERSEL=" , MAINDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 370;
                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                            __context__.SourceCodeLine = 371;
                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                            __context__.SourceCodeLine = 372;
                            MAIN_DECODER_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 375;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:PUREDIRMODE=" , MAINDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 377;
                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                __context__.SourceCodeLine = 378;
                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                __context__.SourceCodeLine = 379;
                                MAIN_PURE_DIRECT_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 382;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ADAPTIVEDRC=" , MAINDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 384;
                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                    __context__.SourceCodeLine = 385;
                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                    __context__.SourceCodeLine = 386;
                                    MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 389;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:LIPSYNCMODE=" , MAINDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 391;
                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                        __context__.SourceCodeLine = 392;
                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                        __context__.SourceCodeLine = 393;
                                        MAIN_LIP_SYNC_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 396;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:STRAIGHT=" , MAINDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 398;
                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                            __context__.SourceCodeLine = 399;
                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                            __context__.SourceCodeLine = 400;
                                            MAIN_STRAIGHT_MODE_STATUS  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 403;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ENHANCER=" , MAINDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 405;
                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                __context__.SourceCodeLine = 406;
                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                __context__.SourceCodeLine = 407;
                                                MAIN_ENHANCER_STATUS  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 410;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SOUNDPRG=" , MAINDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 412;
                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                    __context__.SourceCodeLine = 413;
                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                    __context__.SourceCodeLine = 414;
                                                    MAIN_SOUND_PROG_STATUS  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 417;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ADAPTIVEDSP=" , MAINDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 419;
                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                        __context__.SourceCodeLine = 420;
                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                        __context__.SourceCodeLine = 421;
                                                        MAIN_ADAPTIVE_DSP_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 424;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ADAPTIVEDSP=" , MAINDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 426;
                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                            __context__.SourceCodeLine = 427;
                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                            __context__.SourceCodeLine = 428;
                                                            MAIN_3D_CINEMA_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 431;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:EXSURDECODER=" , MAINDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 433;
                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                __context__.SourceCodeLine = 434;
                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                __context__.SourceCodeLine = 435;
                                                                MAIN_EX_DECODER_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 438;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:2CHDECODER=" , MAINDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 440;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 441;
                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 442;
                                                                    MAIN_2CHAN_DECODER_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 445;
                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIOUT=" , MAINDATA ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 447;
                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                        __context__.SourceCodeLine = 448;
                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                        __context__.SourceCodeLine = 449;
                                                                        MAIN_CURR_HDMI_OUT_CONFIG  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 452;
                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIPROCESSING=" , MAINDATA ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 454;
                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                            __context__.SourceCodeLine = 455;
                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                            __context__.SourceCodeLine = 456;
                                                                            MAIN_HDMI_PROC_STATE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 459;
                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIASPECT=" , MAINDATA ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 461;
                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                __context__.SourceCodeLine = 462;
                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                __context__.SourceCodeLine = 463;
                                                                                MAIN_HDMI_ASPECT  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 466;
                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIRESOL=" , MAINDATA ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 468;
                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                    __context__.SourceCodeLine = 469;
                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                    __context__.SourceCodeLine = 470;
                                                                                    MAIN_HDMI_RES  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 473;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ZONENAME=" , MAINDATA ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 475;
                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                        __context__.SourceCodeLine = 476;
                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                        __context__.SourceCodeLine = 477;
                                                                                        MAIN_ZONE_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 480;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE1NAME=" , MAINDATA ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 482;
                                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                            __context__.SourceCodeLine = 483;
                                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                            __context__.SourceCodeLine = 484;
                                                                                            MAIN_SCENE1_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 487;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE2NAME=" , MAINDATA ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 489;
                                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                __context__.SourceCodeLine = 490;
                                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                __context__.SourceCodeLine = 491;
                                                                                                MAIN_SCENE2_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 494;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE3NAME=" , MAINDATA ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 496;
                                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                    __context__.SourceCodeLine = 497;
                                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                    __context__.SourceCodeLine = 498;
                                                                                                    MAIN_SCENE3_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 501;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE4NAME=" , MAINDATA ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 503;
                                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                        __context__.SourceCodeLine = 504;
                                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                        __context__.SourceCodeLine = 505;
                                                                                                        MAIN_SCENE4_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 508;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE5NAME=" , MAINDATA ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 510;
                                                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                            __context__.SourceCodeLine = 511;
                                                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                            __context__.SourceCodeLine = 512;
                                                                                                            MAIN_SCENE5_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 515;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE6NAME=" , MAINDATA ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 517;
                                                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                __context__.SourceCodeLine = 518;
                                                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                __context__.SourceCodeLine = 519;
                                                                                                                MAIN_SCENE6_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 522;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE7NAME=" , MAINDATA ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 524;
                                                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                    __context__.SourceCodeLine = 525;
                                                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                    __context__.SourceCodeLine = 526;
                                                                                                                    MAIN_SCENE7_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 529;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE8NAME=" , MAINDATA ))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 531;
                                                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                        __context__.SourceCodeLine = 532;
                                                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                        __context__.SourceCodeLine = 533;
                                                                                                                        MAIN_SCENE8_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 536;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE9NAME=" , MAINDATA ))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 538;
                                                                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                            __context__.SourceCodeLine = 539;
                                                                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                            __context__.SourceCodeLine = 540;
                                                                                                                            MAIN_SCENE9_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 543;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE10NAME=" , MAINDATA ))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 545;
                                                                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 546;
                                                                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 547;
                                                                                                                                MAIN_SCENE10_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 550;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE11NAME=" , MAINDATA ))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 552;
                                                                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 553;
                                                                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 554;
                                                                                                                                    MAIN_SCENE11_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 557;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE12NAME=" , MAINDATA ))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 559;
                                                                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 560;
                                                                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 561;
                                                                                                                                        MAIN_SCENE12_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    }
                                                                                                                                
                                                                                                                                }
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEZONE2 (  SplusExecutionContext __context__, CrestronString ZONE2DATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 572;
            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SLEEP=" , ZONE2DATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 574;
                SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                __context__.SourceCodeLine = 575;
                EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                __context__.SourceCodeLine = 576;
                ZONE2_SLEEP_TIMER_TEXT  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 579;
                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:VOL=" , ZONE2DATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 581;
                    SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                    __context__.SourceCodeLine = 582;
                    EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                    __context__.SourceCodeLine = 583;
                    ZONE2_VOL_TEXT  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 586;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:ZONENAME=" , ZONE2DATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 588;
                        SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                        __context__.SourceCodeLine = 589;
                        EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                        __context__.SourceCodeLine = 590;
                        ZONE2_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 593;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE1NAME=" , ZONE2DATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 595;
                            SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                            __context__.SourceCodeLine = 596;
                            EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                            __context__.SourceCodeLine = 597;
                            ZONE2_SCENE1_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 600;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE2NAME=" , ZONE2DATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 602;
                                SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                                __context__.SourceCodeLine = 603;
                                EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                                __context__.SourceCodeLine = 604;
                                ZONE2_SCENE2_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 607;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE3NAME=" , ZONE2DATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 609;
                                    SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                                    __context__.SourceCodeLine = 610;
                                    EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                                    __context__.SourceCodeLine = 611;
                                    ZONE2_SCENE3_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 614;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE4NAME=" , ZONE2DATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 616;
                                        SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                                        __context__.SourceCodeLine = 617;
                                        EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                                        __context__.SourceCodeLine = 618;
                                        ZONE2_SCENE4_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSETUNER (  SplusExecutionContext __context__, CrestronString TUNERDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 629;
            if ( Functions.TestForTrue  ( ( Functions.Find( "TUN:FMFREQ=" , TUNERDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 631;
                SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                __context__.SourceCodeLine = 632;
                EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                __context__.SourceCodeLine = 633;
                TUNER_CURR_STATION  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 636;
                if ( Functions.TestForTrue  ( ( Functions.Find( "TUN:AMFREQ=" , TUNERDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 638;
                    SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                    __context__.SourceCodeLine = 639;
                    EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                    __context__.SourceCodeLine = 640;
                    TUNER_CURR_STATION  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 643;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "TUN:FMMODE=" , TUNERDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 645;
                        SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                        __context__.SourceCodeLine = 646;
                        EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                        __context__.SourceCodeLine = 647;
                        TUNER_FM_MODE  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSESIRIUSXM (  SplusExecutionContext __context__, CrestronString SIRIUSXMDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 657;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LISTLAYER=" , SIRIUSXMDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 659;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                __context__.SourceCodeLine = 660;
                EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                __context__.SourceCodeLine = 661;
                SIRIUSXMLISTLAYER  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 664;
                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LISTLAYERNAME=" , SIRIUSXMDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 666;
                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                    __context__.SourceCodeLine = 667;
                    EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                    __context__.SourceCodeLine = 668;
                    SIRIUSXMLISTNAME  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 671;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE1TXT=" , SIRIUSXMDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 673;
                        SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                        __context__.SourceCodeLine = 674;
                        EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                        __context__.SourceCodeLine = 675;
                        SIRIUSXMLINE1TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 678;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE2TXT=" , SIRIUSXMDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 680;
                            SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                            __context__.SourceCodeLine = 681;
                            EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                            __context__.SourceCodeLine = 682;
                            SIRIUSXMLINE2TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 685;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE3TXT=" , SIRIUSXMDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 687;
                                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                __context__.SourceCodeLine = 688;
                                EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                __context__.SourceCodeLine = 689;
                                SIRIUSXMLINE3TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 692;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE4TXT=" , SIRIUSXMDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 694;
                                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                    __context__.SourceCodeLine = 695;
                                    EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                    __context__.SourceCodeLine = 696;
                                    SIRIUSXMLINE4TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 699;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE5TXT=" , SIRIUSXMDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 701;
                                        SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                        __context__.SourceCodeLine = 702;
                                        EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                        __context__.SourceCodeLine = 703;
                                        SIRIUSXMLINE5TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 706;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE6TXT=" , SIRIUSXMDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 708;
                                            SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                            __context__.SourceCodeLine = 709;
                                            EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                            __context__.SourceCodeLine = 710;
                                            SIRIUSXMLINE6TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 713;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE7TXT=" , SIRIUSXMDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 715;
                                                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                                __context__.SourceCodeLine = 716;
                                                EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                                __context__.SourceCodeLine = 717;
                                                SIRIUSXMLINE7TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 720;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:LINE8TXT=" , SIRIUSXMDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 722;
                                                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                                    __context__.SourceCodeLine = 723;
                                                    EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                                    __context__.SourceCodeLine = 724;
                                                    SIRIUSXMLINE8TEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 727;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:SONG=" , SIRIUSXMDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 729;
                                                        SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                                        __context__.SourceCodeLine = 730;
                                                        EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                                        __context__.SourceCodeLine = 731;
                                                        SIRIUSXMCURRSONGTEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 734;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:ARTIST=" , SIRIUSXMDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 736;
                                                            SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                                            __context__.SourceCodeLine = 737;
                                                            EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                                            __context__.SourceCodeLine = 738;
                                                            SIRIUSXMCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 741;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:ALBUM=" , SIRIUSXMDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 743;
                                                                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                                                __context__.SourceCodeLine = 744;
                                                                EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                                                __context__.SourceCodeLine = 745;
                                                                SIRIUSXMCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 748;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSXM:CHNAME=" , SIRIUSXMDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 750;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSXMDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 751;
                                                                    EPOS = (ushort) ( Functions.Length( SIRIUSXMDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 752;
                                                                    SIRIUSXMCURRCHANNELTEXT  .UpdateValue ( Functions.Mid ( SIRIUSXMDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSERHAP (  SplusExecutionContext __context__, CrestronString RHAPDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 763;
            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LISTLAYER=" , RHAPDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 765;
                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                __context__.SourceCodeLine = 766;
                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                __context__.SourceCodeLine = 767;
                RHAPLISTLAYER  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 770;
                if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LISTLAYERNAME=" , RHAPDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 772;
                    SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                    __context__.SourceCodeLine = 773;
                    EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                    __context__.SourceCodeLine = 774;
                    RHAPLISTNAME  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 777;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE1TXT=" , RHAPDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 779;
                        SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                        __context__.SourceCodeLine = 780;
                        EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                        __context__.SourceCodeLine = 781;
                        RHAPLINE1TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 784;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE2TXT=" , RHAPDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 786;
                            SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                            __context__.SourceCodeLine = 787;
                            EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                            __context__.SourceCodeLine = 788;
                            RHAPLINE2TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 791;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE3TXT=" , RHAPDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 793;
                                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                __context__.SourceCodeLine = 794;
                                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                __context__.SourceCodeLine = 795;
                                RHAPLINE3TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 798;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE4TXT=" , RHAPDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 800;
                                    SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                    __context__.SourceCodeLine = 801;
                                    EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                    __context__.SourceCodeLine = 802;
                                    RHAPLINE4TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 805;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE5TXT=" , RHAPDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 807;
                                        SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                        __context__.SourceCodeLine = 808;
                                        EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                        __context__.SourceCodeLine = 809;
                                        RHAPLINE5TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 812;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE6TXT=" , RHAPDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 814;
                                            SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                            __context__.SourceCodeLine = 815;
                                            EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                            __context__.SourceCodeLine = 816;
                                            RHAPLINE6TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 819;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE7TXT=" , RHAPDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 821;
                                                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                __context__.SourceCodeLine = 822;
                                                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                __context__.SourceCodeLine = 823;
                                                RHAPLINE7TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 826;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE8TXT=" , RHAPDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 828;
                                                    SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                    __context__.SourceCodeLine = 829;
                                                    EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                    __context__.SourceCodeLine = 830;
                                                    RHAPLINE8TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 833;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:SONG=" , RHAPDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 835;
                                                        SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                        __context__.SourceCodeLine = 836;
                                                        EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                        __context__.SourceCodeLine = 837;
                                                        RHAPCURRSONGTEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 840;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:ARTIST=" , RHAPDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 842;
                                                            SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                            __context__.SourceCodeLine = 843;
                                                            EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                            __context__.SourceCodeLine = 844;
                                                            RHAPCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 847;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:ALBUM=" , RHAPDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 849;
                                                                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                                __context__.SourceCodeLine = 850;
                                                                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                                __context__.SourceCodeLine = 851;
                                                                RHAPCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEPANDORA (  SplusExecutionContext __context__, CrestronString PANDORADATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 862;
            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LISTLAYER=" , PANDORADATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 864;
                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                __context__.SourceCodeLine = 865;
                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                __context__.SourceCodeLine = 866;
                PANDLISTLAYER  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 869;
                if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LISTLAYERNAME=" , PANDORADATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 871;
                    SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                    __context__.SourceCodeLine = 872;
                    EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                    __context__.SourceCodeLine = 873;
                    PANDLISTNAME  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 876;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE1TXT=" , PANDORADATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 878;
                        SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                        __context__.SourceCodeLine = 879;
                        EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                        __context__.SourceCodeLine = 880;
                        PANDLINE1TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 883;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE2TXT=" , PANDORADATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 885;
                            SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                            __context__.SourceCodeLine = 886;
                            EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                            __context__.SourceCodeLine = 887;
                            PANDLINE2TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 890;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE3TXT=" , PANDORADATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 892;
                                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                __context__.SourceCodeLine = 893;
                                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                __context__.SourceCodeLine = 894;
                                PANDLINE3TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 897;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE4TXT=" , PANDORADATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 899;
                                    SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                    __context__.SourceCodeLine = 900;
                                    EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                    __context__.SourceCodeLine = 901;
                                    PANDLINE4TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 904;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE5TXT=" , PANDORADATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 906;
                                        SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                        __context__.SourceCodeLine = 907;
                                        EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                        __context__.SourceCodeLine = 908;
                                        PANDLINE5TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 911;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE6TXT=" , PANDORADATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 913;
                                            SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                            __context__.SourceCodeLine = 914;
                                            EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                            __context__.SourceCodeLine = 915;
                                            PANDLINE6TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 918;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE7TXT=" , PANDORADATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 920;
                                                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                __context__.SourceCodeLine = 921;
                                                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                __context__.SourceCodeLine = 922;
                                                PANDLINE7TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 925;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE8TXT=" , PANDORADATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 927;
                                                    SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                    __context__.SourceCodeLine = 928;
                                                    EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                    __context__.SourceCodeLine = 929;
                                                    PANDLINE8TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 932;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:TRACK=" , PANDORADATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 934;
                                                        SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                        __context__.SourceCodeLine = 935;
                                                        EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                        __context__.SourceCodeLine = 936;
                                                        PANDCURRSONGTEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 939;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:ALBUM=" , PANDORADATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 941;
                                                            SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                            __context__.SourceCodeLine = 942;
                                                            EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                            __context__.SourceCodeLine = 943;
                                                            PANDCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 946;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:STATION=" , PANDORADATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 948;
                                                                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                                __context__.SourceCodeLine = 949;
                                                                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                                __context__.SourceCodeLine = 950;
                                                                PANDCURRSTATIONTEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSENETRADIO (  SplusExecutionContext __context__, CrestronString NETRADIODATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 963;
            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LISTLAYER=" , NETRADIODATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 965;
                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                __context__.SourceCodeLine = 966;
                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                __context__.SourceCodeLine = 967;
                NETRADIOLISTLAYER  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 970;
                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LISTLAYERNAME=" , NETRADIODATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 972;
                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                    __context__.SourceCodeLine = 973;
                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                    __context__.SourceCodeLine = 974;
                    NETRADIOLISTNAME  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 977;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE1TXT=" , NETRADIODATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 979;
                        SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                        __context__.SourceCodeLine = 980;
                        EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                        __context__.SourceCodeLine = 981;
                        NETRADIOLINE1TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 984;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE2TXT=" , NETRADIODATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 986;
                            SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                            __context__.SourceCodeLine = 987;
                            EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                            __context__.SourceCodeLine = 988;
                            NETRADIOLINE2TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 991;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE3TXT=" , NETRADIODATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 993;
                                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                __context__.SourceCodeLine = 994;
                                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                __context__.SourceCodeLine = 995;
                                NETRADIOLINE3TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 998;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE4TXT=" , NETRADIODATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1000;
                                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                    __context__.SourceCodeLine = 1001;
                                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                    __context__.SourceCodeLine = 1002;
                                    NETRADIOLINE4TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1005;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE5TXT=" , NETRADIODATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1007;
                                        SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                        __context__.SourceCodeLine = 1008;
                                        EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                        __context__.SourceCodeLine = 1009;
                                        NETRADIOLINE5TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1012;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE6TXT=" , NETRADIODATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1014;
                                            SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                            __context__.SourceCodeLine = 1015;
                                            EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                            __context__.SourceCodeLine = 1016;
                                            NETRADIOLINE6TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1019;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE7TXT=" , NETRADIODATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1021;
                                                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                __context__.SourceCodeLine = 1022;
                                                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                __context__.SourceCodeLine = 1023;
                                                NETRADIOLINE7TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1026;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE8TXT=" , NETRADIODATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1028;
                                                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                    __context__.SourceCodeLine = 1029;
                                                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                    __context__.SourceCodeLine = 1030;
                                                    NETRADIOLINE8TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1033;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:SONG=" , NETRADIODATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1035;
                                                        SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                        __context__.SourceCodeLine = 1036;
                                                        EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                        __context__.SourceCodeLine = 1037;
                                                        NETRADIOCURRSONGTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1040;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:ARTIST=" , NETRADIODATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1042;
                                                            SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                            __context__.SourceCodeLine = 1043;
                                                            EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                            __context__.SourceCodeLine = 1044;
                                                            NETRADIOCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1047;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:ALBUM=" , NETRADIODATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1049;
                                                                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                                __context__.SourceCodeLine = 1050;
                                                                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                                __context__.SourceCodeLine = 1051;
                                                                NETRADIOCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1054;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:STATION=" , NETRADIODATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1056;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                                    __context__.SourceCodeLine = 1057;
                                                                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                                    __context__.SourceCodeLine = 1058;
                                                                    NETRADIOCURRCHANNELTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEUSB (  SplusExecutionContext __context__, CrestronString USBDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1069;
            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LISTLAYER=" , USBDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1071;
                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                __context__.SourceCodeLine = 1072;
                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                __context__.SourceCodeLine = 1073;
                USBLISTLAYER  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1076;
                if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LISTLAYERNAME=" , USBDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1078;
                    SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                    __context__.SourceCodeLine = 1079;
                    EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                    __context__.SourceCodeLine = 1080;
                    USBLISTNAME  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1083;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE1TXT=" , USBDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1085;
                        SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                        __context__.SourceCodeLine = 1086;
                        EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                        __context__.SourceCodeLine = 1087;
                        USBLINE1TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1090;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE2TXT=" , USBDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1092;
                            SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                            __context__.SourceCodeLine = 1093;
                            EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                            __context__.SourceCodeLine = 1094;
                            USBLINE2TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1097;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE3TXT=" , USBDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1099;
                                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                __context__.SourceCodeLine = 1100;
                                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                __context__.SourceCodeLine = 1101;
                                USBLINE3TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1104;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE4TXT=" , USBDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1106;
                                    SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                    __context__.SourceCodeLine = 1107;
                                    EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                    __context__.SourceCodeLine = 1108;
                                    USBLINE4TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1111;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE5TXT=" , USBDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1113;
                                        SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                        __context__.SourceCodeLine = 1114;
                                        EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                        __context__.SourceCodeLine = 1115;
                                        USBLINE5TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1118;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE6TXT=" , USBDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1120;
                                            SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                            __context__.SourceCodeLine = 1121;
                                            EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                            __context__.SourceCodeLine = 1122;
                                            USBLINE6TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1125;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE7TXT=" , USBDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1127;
                                                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                __context__.SourceCodeLine = 1128;
                                                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                __context__.SourceCodeLine = 1129;
                                                USBLINE7TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1132;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE8TXT=" , USBDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1134;
                                                    SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1135;
                                                    EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1136;
                                                    USBLINE8TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1139;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "USB:SONG=" , USBDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1141;
                                                        SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1142;
                                                        EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1143;
                                                        USBCURRSONGTEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1146;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "USB:ARTIST=" , USBDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1148;
                                                            SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1149;
                                                            EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1150;
                                                            USBCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1153;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:ALBUM=" , USBDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1155;
                                                                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1156;
                                                                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1157;
                                                                USBCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEIPODUSB (  SplusExecutionContext __context__, CrestronString IPODUSBDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1168;
            if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LISTLAYER=" , IPODUSBDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1170;
                SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                __context__.SourceCodeLine = 1171;
                EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                __context__.SourceCodeLine = 1172;
                IPODUSBLISTLAYER  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1175;
                if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSBB:LISTLAYERNAME=" , IPODUSBDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1177;
                    SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                    __context__.SourceCodeLine = 1178;
                    EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                    __context__.SourceCodeLine = 1179;
                    IPODUSBLISTNAME  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1182;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE1TXT=" , IPODUSBDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1184;
                        SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                        __context__.SourceCodeLine = 1185;
                        EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                        __context__.SourceCodeLine = 1186;
                        IPODUSBLINE1TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1189;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE2TXT=" , IPODUSBDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1191;
                            SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                            __context__.SourceCodeLine = 1192;
                            EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                            __context__.SourceCodeLine = 1193;
                            IPODUSBLINE2TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1196;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE3TXT=" , IPODUSBDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1198;
                                SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                __context__.SourceCodeLine = 1199;
                                EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                __context__.SourceCodeLine = 1200;
                                IPODUSBLINE3TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1203;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE4TXT=" , IPODUSBDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1205;
                                    SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                    __context__.SourceCodeLine = 1206;
                                    EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                    __context__.SourceCodeLine = 1207;
                                    IPODUSBLINE4TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1210;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE5TXT=" , IPODUSBDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1212;
                                        SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                        __context__.SourceCodeLine = 1213;
                                        EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                        __context__.SourceCodeLine = 1214;
                                        IPODUSBLINE5TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1217;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE6TXT=" , IPODUSBDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1219;
                                            SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                            __context__.SourceCodeLine = 1220;
                                            EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                            __context__.SourceCodeLine = 1221;
                                            IPODUSBLINE6TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1224;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE7TXT=" , IPODUSBDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1226;
                                                SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                                __context__.SourceCodeLine = 1227;
                                                EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                                __context__.SourceCodeLine = 1228;
                                                IPODUSBLINE7TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1231;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:LINE8TXT=" , IPODUSBDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1233;
                                                    SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1234;
                                                    EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1235;
                                                    IPODUSBLINE8TEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1238;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:SONG=" , IPODUSBDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1240;
                                                        SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1241;
                                                        EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1242;
                                                        IPODUSBCURRSONGTEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1245;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:ARTIST=" , IPODUSBDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1247;
                                                            SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1248;
                                                            EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1249;
                                                            IPODUSBCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1252;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "IPODUSB:ALBUM=" , IPODUSBDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1254;
                                                                SPOS = (ushort) ( Functions.Find( "=" , IPODUSBDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1255;
                                                                EPOS = (ushort) ( Functions.Length( IPODUSBDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1256;
                                                                IPODUSBCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( IPODUSBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSESERVER (  SplusExecutionContext __context__, CrestronString SERVERDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1266;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LISTLAYER=" , SERVERDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1268;
                SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                __context__.SourceCodeLine = 1269;
                EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                __context__.SourceCodeLine = 1270;
                SERVERLISTLAYER  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1273;
                if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LISTLAYERNAME=" , SERVERDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1275;
                    SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                    __context__.SourceCodeLine = 1276;
                    EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                    __context__.SourceCodeLine = 1277;
                    SERVERLISTNAME  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1280;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE1TXT=" , SERVERDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1282;
                        SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                        __context__.SourceCodeLine = 1283;
                        EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                        __context__.SourceCodeLine = 1284;
                        SERVERLINE1TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1287;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE2TXT=" , SERVERDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1289;
                            SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                            __context__.SourceCodeLine = 1290;
                            EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                            __context__.SourceCodeLine = 1291;
                            SERVERLINE2TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1294;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE3TXT=" , SERVERDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1296;
                                SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                __context__.SourceCodeLine = 1297;
                                EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                __context__.SourceCodeLine = 1298;
                                SERVERLINE3TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1301;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE4TXT=" , SERVERDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1303;
                                    SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                    __context__.SourceCodeLine = 1304;
                                    EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                    __context__.SourceCodeLine = 1305;
                                    SERVERLINE4TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1308;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE5TXT=" , SERVERDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1310;
                                        SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                        __context__.SourceCodeLine = 1311;
                                        EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                        __context__.SourceCodeLine = 1312;
                                        SERVERLINE5TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1315;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE6TXT=" , SERVERDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1317;
                                            SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                            __context__.SourceCodeLine = 1318;
                                            EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                            __context__.SourceCodeLine = 1319;
                                            SERVERLINE6TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1322;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE7TXT=" , SERVERDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1324;
                                                SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                                __context__.SourceCodeLine = 1325;
                                                EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                                __context__.SourceCodeLine = 1326;
                                                SERVERLINE7TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1329;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:LINE8TXT=" , SERVERDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1331;
                                                    SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1332;
                                                    EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1333;
                                                    SERVERLINE8TEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1336;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:SONG=" , SERVERDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1338;
                                                        SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1339;
                                                        EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1340;
                                                        SERVERCURRSONGTEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1343;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:ARTIST=" , SERVERDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1345;
                                                            SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1346;
                                                            EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1347;
                                                            SERVERCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1350;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "SERVER:ALBUM=" , SERVERDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1352;
                                                                SPOS = (ushort) ( Functions.Find( "=" , SERVERDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1353;
                                                                EPOS = (ushort) ( Functions.Length( SERVERDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1354;
                                                                SERVERCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( SERVERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEAIRPLAY (  SplusExecutionContext __context__, CrestronString AIRPLAYDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1364;
            if ( Functions.TestForTrue  ( ( Functions.Find( "AIRPLAY:ARTIST=" , AIRPLAYDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1366;
                SPOS = (ushort) ( Functions.Find( "=" , AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1367;
                EPOS = (ushort) ( Functions.Length( AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1368;
                AIRPLAYCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( AIRPLAYDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1370;
            if ( Functions.TestForTrue  ( ( Functions.Find( "AIRPLAY:SONG=" , AIRPLAYDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1372;
                SPOS = (ushort) ( Functions.Find( "=" , AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1373;
                EPOS = (ushort) ( Functions.Length( AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1374;
                AIRPLAYCURRSONGTEXT  .UpdateValue ( Functions.Mid ( AIRPLAYDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1376;
            if ( Functions.TestForTrue  ( ( Functions.Find( "AIRPLAY:ALBUM=" , AIRPLAYDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1378;
                SPOS = (ushort) ( Functions.Find( "=" , AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1379;
                EPOS = (ushort) ( Functions.Length( AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1380;
                AIRPLAYCURRCOMPTEXT  .UpdateValue ( Functions.Mid ( AIRPLAYDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1382;
            if ( Functions.TestForTrue  ( ( Functions.Find( "AIRPLAY:PLAYBACKINFO=" , AIRPLAYDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1384;
                SPOS = (ushort) ( Functions.Find( "=" , AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1385;
                EPOS = (ushort) ( Functions.Length( AIRPLAYDATA ) ) ; 
                __context__.SourceCodeLine = 1386;
                AIRPLAYCURRCOMPTEXT  .UpdateValue ( Functions.Mid ( AIRPLAYDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1388;
                if ( Functions.TestForTrue  ( ( Functions.Find( "AIRPLAY:VOLINTERLOCK=" , AIRPLAYDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1390;
                    SPOS = (ushort) ( Functions.Find( "=" , AIRPLAYDATA ) ) ; 
                    __context__.SourceCodeLine = 1391;
                    EPOS = (ushort) ( Functions.Length( AIRPLAYDATA ) ) ; 
                    __context__.SourceCodeLine = 1392;
                    AIRPLAY_VOL_TEXT  .UpdateValue ( Functions.Mid ( AIRPLAYDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                }
            
            
            }
            
        private void FNPROCESSDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 600, this );
            
            CrestronString STRASH;
            STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 1403;
            while ( Functions.TestForTrue  ( ( Functions.Find( "\u000D\u000A" , SDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1405;
                STEMP  .UpdateValue ( FN_PARSEDELIMITEDTEXT (  __context__ , SDATA, "@", "\u000D\u000A", (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1406;
                STRASH  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , SDATA )  ) ; 
                __context__.SourceCodeLine = 1408;
                RXPROCESSED  .UpdateValue ( STEMP  ) ; 
                __context__.SourceCodeLine = 1410;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)1);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "MAIN" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1414;
                            FN_PARSEMAIN (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "Zone2" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1419;
                            FN_PARSEZONE2 (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "TUN" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1424;
                            FN_PARSETUNER (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "IPODUSB" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1429;
                            FN_PARSEIPODUSB (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "USB" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1434;
                            FN_PARSEUSB (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "PANDORA" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1439;
                            Functions.Delay (  (int) ( 1 ) ) ; 
                            __context__.SourceCodeLine = 1440;
                            FN_PARSEPANDORA (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "SIRIUSXM" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1445;
                            FN_PARSESIRIUSXM (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "RHAP" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1450;
                            FN_PARSERHAP (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "NETRADIO" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1455;
                            FN_PARSENETRADIO (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "SERVER" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1459;
                            FN_PARSESERVER (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "AIRPLAY" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1463;
                            FN_PARSEAIRPLAY (  __context__ , STEMP) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 1403;
                } 
            
            __context__.SourceCodeLine = 1467;
            Functions.ClearBuffer ( SDATA ) ; 
            __context__.SourceCodeLine = 1468;
            Functions.ClearBuffer ( _SplusNVRAM.G_SDATA ) ; 
            __context__.SourceCodeLine = 1469;
            /* Trace( "Parsing OFF\r\n") */ ; 
            __context__.SourceCodeLine = 1470;
            _SplusNVRAM.G_BPARSING = (ushort) ( 0 ) ; 
            
            }
            
        object CONNECT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1482;
                Functions.SocketConnectClient ( CLIENTSOCKET , CLIENTSOCKETADDRESS ,  (ushort) ( CLIENTSOCKETPORT  .Value ) ,  (ushort) ( 1 ) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CMDIN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1487;
            _SplusNVRAM.CMDTOSEND  .UpdateValue ( CMDIN  ) ; 
            __context__.SourceCodeLine = 1489;
            RS232_TO_DEV  .UpdateValue ( _SplusNVRAM.CMDTOSEND  ) ; 
            __context__.SourceCodeLine = 1491;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CLIENTSOCKETSTATUS == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 1493;
                Functions.SocketSend ( CLIENTSOCKET , _SplusNVRAM.CMDTOSEND ) ; 
                __context__.SourceCodeLine = 1494;
                _SplusNVRAM.CMDTOSEND  .UpdateValue ( ""  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TUNERDIRVAL_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1500;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNERISFM  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1502;
            MakeString ( _SplusNVRAM.CMDTOSEND , "@TUN:FMFREQ={0:d}\r\n", (short)TUNERDIRVAL  .UshortValue) ; 
            __context__.SourceCodeLine = 1504;
            RS232_TO_DEV  .UpdateValue ( _SplusNVRAM.CMDTOSEND  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1510;
            MakeString ( _SplusNVRAM.CMDTOSEND , "@TUN:AMFREQ={0:d}\r\n", (short)TUNERDIRVAL  .UshortValue) ; 
            __context__.SourceCodeLine = 1512;
            RS232_TO_DEV  .UpdateValue ( _SplusNVRAM.CMDTOSEND  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RS232FROMDEV_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1523;
        _SplusNVRAM.G_SDATA  .UpdateValue ( Functions.Gather ( "\u000D\u000A" , RS232FROMDEV , 500)  ) ; 
        __context__.SourceCodeLine = 1524;
        /* Trace( "g_sData is {0}\r\n", _SplusNVRAM.G_SDATA ) */ ; 
        __context__.SourceCodeLine = 1528;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.G_SDATA ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1531;
            /* Trace( "Parsing ON\r\n") */ ; 
            __context__.SourceCodeLine = 1533;
            FNPROCESSDATA (  __context__ , _SplusNVRAM.G_SDATA) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENTSOCKET_OnSocketConnect_4 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 1567;
        CONNECTED  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENTSOCKET_OnSocketDisconnect_5 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 1574;
        CONNECTED  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENTSOCKET_OnSocketStatus_6 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 1580;
        _SplusNVRAM.CLIENTSOCKETSTATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENTSOCKET_OnSocketReceive_7 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 1588;
        while ( Functions.TestForTrue  ( ( _SplusNVRAM.G_BPARSING)  ) ) 
            {
            __context__.SourceCodeLine = 1588;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 1588;
            }
        
        __context__.SourceCodeLine = 1590;
        _SplusNVRAM.G_SDATA  .UpdateValue ( CLIENTSOCKET .  SocketRxBuf  ) ; 
        __context__.SourceCodeLine = 1591;
        Functions.ClearBuffer ( CLIENTSOCKET .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 1593;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.G_SDATA ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1595;
            _SplusNVRAM.G_BPARSING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1596;
            /* Trace( "Parsing ON") */ ; 
            __context__.SourceCodeLine = 1598;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 1 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 1598;
            FNPROCESSDATA (  __context__ , _SplusNVRAM.G_SDATA) ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 1609;
        _SplusNVRAM.G_BPARSING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.CMDTOSEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    _SplusNVRAM.G_SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65534, this );
    CLIENTSOCKET  = new SplusTcpClient ( 65534, this );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalInput( CONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECT__DigitalInput__, CONNECT );
    
    TUNERISFM = new Crestron.Logos.SplusObjects.DigitalInput( TUNERISFM__DigitalInput__, this );
    m_DigitalInputList.Add( TUNERISFM__DigitalInput__, TUNERISFM );
    
    TUNERISAM = new Crestron.Logos.SplusObjects.DigitalInput( TUNERISAM__DigitalInput__, this );
    m_DigitalInputList.Add( TUNERISAM__DigitalInput__, TUNERISAM );
    
    CONNECTED = new Crestron.Logos.SplusObjects.DigitalOutput( CONNECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONNECTED__DigitalOutput__, CONNECTED );
    
    TUNERDIRVAL = new Crestron.Logos.SplusObjects.AnalogInput( TUNERDIRVAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TUNERDIRVAL__AnalogSerialInput__, TUNERDIRVAL );
    
    CMDIN = new Crestron.Logos.SplusObjects.StringInput( CMDIN__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( CMDIN__AnalogSerialInput__, CMDIN );
    
    RXPROCESSED = new Crestron.Logos.SplusObjects.StringOutput( RXPROCESSED__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RXPROCESSED__AnalogSerialOutput__, RXPROCESSED );
    
    RS232_TO_DEV = new Crestron.Logos.SplusObjects.StringOutput( RS232_TO_DEV__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RS232_TO_DEV__AnalogSerialOutput__, RS232_TO_DEV );
    
    MAIN_ZONE_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ZONE_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ZONE_NAME__AnalogSerialOutput__, MAIN_ZONE_NAME );
    
    MAIN_SCENE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE1_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE1_NAME__AnalogSerialOutput__, MAIN_SCENE1_NAME );
    
    MAIN_SCENE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE2_NAME__AnalogSerialOutput__, MAIN_SCENE2_NAME );
    
    MAIN_SCENE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE3_NAME__AnalogSerialOutput__, MAIN_SCENE3_NAME );
    
    MAIN_SCENE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE4_NAME__AnalogSerialOutput__, MAIN_SCENE4_NAME );
    
    MAIN_SCENE5_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE5_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE5_NAME__AnalogSerialOutput__, MAIN_SCENE5_NAME );
    
    MAIN_SCENE6_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE6_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE6_NAME__AnalogSerialOutput__, MAIN_SCENE6_NAME );
    
    MAIN_SCENE7_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE7_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE7_NAME__AnalogSerialOutput__, MAIN_SCENE7_NAME );
    
    MAIN_SCENE8_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE8_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE8_NAME__AnalogSerialOutput__, MAIN_SCENE8_NAME );
    
    MAIN_SCENE9_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE9_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE9_NAME__AnalogSerialOutput__, MAIN_SCENE9_NAME );
    
    MAIN_SCENE10_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE10_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE10_NAME__AnalogSerialOutput__, MAIN_SCENE10_NAME );
    
    MAIN_SCENE11_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE11_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE11_NAME__AnalogSerialOutput__, MAIN_SCENE11_NAME );
    
    MAIN_SCENE12_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE12_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE12_NAME__AnalogSerialOutput__, MAIN_SCENE12_NAME );
    
    MAIN_SLEEP_TIMER_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SLEEP_TIMER_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SLEEP_TIMER_TEXT__AnalogSerialOutput__, MAIN_SLEEP_TIMER_TEXT );
    
    MAIN_VOL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_VOL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_VOL_TEXT__AnalogSerialOutput__, MAIN_VOL_TEXT );
    
    MAIN_CURR_INPUT_AUDIO_TYPE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_CURR_INPUT_AUDIO_TYPE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_CURR_INPUT_AUDIO_TYPE__AnalogSerialOutput__, MAIN_CURR_INPUT_AUDIO_TYPE );
    
    MAIN_DECODER_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_DECODER_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_DECODER_MODE__AnalogSerialOutput__, MAIN_DECODER_MODE );
    
    MAIN_PURE_DIRECT_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_PURE_DIRECT_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_PURE_DIRECT_MODE__AnalogSerialOutput__, MAIN_PURE_DIRECT_MODE );
    
    MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE__AnalogSerialOutput__, MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE );
    
    MAIN_LIP_SYNC_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_LIP_SYNC_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_LIP_SYNC_MODE__AnalogSerialOutput__, MAIN_LIP_SYNC_MODE );
    
    MAIN_STRAIGHT_MODE_STATUS = new Crestron.Logos.SplusObjects.StringOutput( MAIN_STRAIGHT_MODE_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_STRAIGHT_MODE_STATUS__AnalogSerialOutput__, MAIN_STRAIGHT_MODE_STATUS );
    
    MAIN_ENHANCER_STATUS = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ENHANCER_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ENHANCER_STATUS__AnalogSerialOutput__, MAIN_ENHANCER_STATUS );
    
    MAIN_SOUND_PROG_STATUS = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SOUND_PROG_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SOUND_PROG_STATUS__AnalogSerialOutput__, MAIN_SOUND_PROG_STATUS );
    
    MAIN_ADAPTIVE_DSP_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ADAPTIVE_DSP_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ADAPTIVE_DSP_MODE__AnalogSerialOutput__, MAIN_ADAPTIVE_DSP_MODE );
    
    MAIN_3D_CINEMA_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_3D_CINEMA_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_3D_CINEMA_MODE__AnalogSerialOutput__, MAIN_3D_CINEMA_MODE );
    
    MAIN_EX_DECODER_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_EX_DECODER_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_EX_DECODER_MODE__AnalogSerialOutput__, MAIN_EX_DECODER_MODE );
    
    MAIN_2CHAN_DECODER_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_2CHAN_DECODER_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_2CHAN_DECODER_MODE__AnalogSerialOutput__, MAIN_2CHAN_DECODER_MODE );
    
    MAIN_CURR_HDMI_OUT_CONFIG = new Crestron.Logos.SplusObjects.StringOutput( MAIN_CURR_HDMI_OUT_CONFIG__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_CURR_HDMI_OUT_CONFIG__AnalogSerialOutput__, MAIN_CURR_HDMI_OUT_CONFIG );
    
    MAIN_HDMI_PROC_STATE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_HDMI_PROC_STATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_HDMI_PROC_STATE__AnalogSerialOutput__, MAIN_HDMI_PROC_STATE );
    
    MAIN_HDMI_ASPECT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_HDMI_ASPECT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_HDMI_ASPECT__AnalogSerialOutput__, MAIN_HDMI_ASPECT );
    
    MAIN_HDMI_RES = new Crestron.Logos.SplusObjects.StringOutput( MAIN_HDMI_RES__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_HDMI_RES__AnalogSerialOutput__, MAIN_HDMI_RES );
    
    ZONE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_NAME__AnalogSerialOutput__, ZONE2_NAME );
    
    ZONE2_SCENE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE1_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE1_NAME__AnalogSerialOutput__, ZONE2_SCENE1_NAME );
    
    ZONE2_SCENE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE2_NAME__AnalogSerialOutput__, ZONE2_SCENE2_NAME );
    
    ZONE2_SCENE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE3_NAME__AnalogSerialOutput__, ZONE2_SCENE3_NAME );
    
    ZONE2_SCENE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE4_NAME__AnalogSerialOutput__, ZONE2_SCENE4_NAME );
    
    ZONE2_SLEEP_TIMER_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SLEEP_TIMER_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SLEEP_TIMER_TEXT__AnalogSerialOutput__, ZONE2_SLEEP_TIMER_TEXT );
    
    ZONE2_VOL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_VOL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_VOL_TEXT__AnalogSerialOutput__, ZONE2_VOL_TEXT );
    
    TUNER_CURR_STATION = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_STATION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_STATION__AnalogSerialOutput__, TUNER_CURR_STATION );
    
    TUNER_FM_MODE = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FM_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FM_MODE__AnalogSerialOutput__, TUNER_FM_MODE );
    
    NETRADIOLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLISTLAYER__AnalogSerialOutput__, NETRADIOLISTLAYER );
    
    NETRADIOLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLISTNAME__AnalogSerialOutput__, NETRADIOLISTNAME );
    
    NETRADIOLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE1TEXT__AnalogSerialOutput__, NETRADIOLINE1TEXT );
    
    NETRADIOLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE2TEXT__AnalogSerialOutput__, NETRADIOLINE2TEXT );
    
    NETRADIOLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE3TEXT__AnalogSerialOutput__, NETRADIOLINE3TEXT );
    
    NETRADIOLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE4TEXT__AnalogSerialOutput__, NETRADIOLINE4TEXT );
    
    NETRADIOLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE5TEXT__AnalogSerialOutput__, NETRADIOLINE5TEXT );
    
    NETRADIOLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE6TEXT__AnalogSerialOutput__, NETRADIOLINE6TEXT );
    
    NETRADIOLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE7TEXT__AnalogSerialOutput__, NETRADIOLINE7TEXT );
    
    NETRADIOLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE8TEXT__AnalogSerialOutput__, NETRADIOLINE8TEXT );
    
    NETRADIOCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRSONGTEXT__AnalogSerialOutput__, NETRADIOCURRSONGTEXT );
    
    NETRADIOCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRARTISTTEXT__AnalogSerialOutput__, NETRADIOCURRARTISTTEXT );
    
    NETRADIOCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRALBUMTEXT__AnalogSerialOutput__, NETRADIOCURRALBUMTEXT );
    
    NETRADIOCURRCHANNELTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRCHANNELTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRCHANNELTEXT__AnalogSerialOutput__, NETRADIOCURRCHANNELTEXT );
    
    PANDLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( PANDLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLISTLAYER__AnalogSerialOutput__, PANDLISTLAYER );
    
    PANDLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( PANDLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLISTNAME__AnalogSerialOutput__, PANDLISTNAME );
    
    PANDLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE1TEXT__AnalogSerialOutput__, PANDLINE1TEXT );
    
    PANDLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE2TEXT__AnalogSerialOutput__, PANDLINE2TEXT );
    
    PANDLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE3TEXT__AnalogSerialOutput__, PANDLINE3TEXT );
    
    PANDLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE4TEXT__AnalogSerialOutput__, PANDLINE4TEXT );
    
    PANDLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE5TEXT__AnalogSerialOutput__, PANDLINE5TEXT );
    
    PANDLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE6TEXT__AnalogSerialOutput__, PANDLINE6TEXT );
    
    PANDLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE7TEXT__AnalogSerialOutput__, PANDLINE7TEXT );
    
    PANDLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE8TEXT__AnalogSerialOutput__, PANDLINE8TEXT );
    
    PANDCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDCURRSONGTEXT__AnalogSerialOutput__, PANDCURRSONGTEXT );
    
    PANDCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDCURRALBUMTEXT__AnalogSerialOutput__, PANDCURRALBUMTEXT );
    
    PANDCURRSTATIONTEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDCURRSTATIONTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDCURRSTATIONTEXT__AnalogSerialOutput__, PANDCURRSTATIONTEXT );
    
    USBLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( USBLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLISTLAYER__AnalogSerialOutput__, USBLISTLAYER );
    
    USBLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( USBLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLISTNAME__AnalogSerialOutput__, USBLISTNAME );
    
    USBLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE1TEXT__AnalogSerialOutput__, USBLINE1TEXT );
    
    USBLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE2TEXT__AnalogSerialOutput__, USBLINE2TEXT );
    
    USBLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE3TEXT__AnalogSerialOutput__, USBLINE3TEXT );
    
    USBLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE4TEXT__AnalogSerialOutput__, USBLINE4TEXT );
    
    USBLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE5TEXT__AnalogSerialOutput__, USBLINE5TEXT );
    
    USBLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE6TEXT__AnalogSerialOutput__, USBLINE6TEXT );
    
    USBLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE7TEXT__AnalogSerialOutput__, USBLINE7TEXT );
    
    USBLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE8TEXT__AnalogSerialOutput__, USBLINE8TEXT );
    
    USBCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( USBCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBCURRSONGTEXT__AnalogSerialOutput__, USBCURRSONGTEXT );
    
    USBCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( USBCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBCURRARTISTTEXT__AnalogSerialOutput__, USBCURRARTISTTEXT );
    
    USBCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( USBCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBCURRALBUMTEXT__AnalogSerialOutput__, USBCURRALBUMTEXT );
    
    SERVERLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( SERVERLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLISTLAYER__AnalogSerialOutput__, SERVERLISTLAYER );
    
    SERVERLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( SERVERLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLISTNAME__AnalogSerialOutput__, SERVERLISTNAME );
    
    SERVERLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE1TEXT__AnalogSerialOutput__, SERVERLINE1TEXT );
    
    SERVERLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE2TEXT__AnalogSerialOutput__, SERVERLINE2TEXT );
    
    SERVERLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE3TEXT__AnalogSerialOutput__, SERVERLINE3TEXT );
    
    SERVERLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE4TEXT__AnalogSerialOutput__, SERVERLINE4TEXT );
    
    SERVERLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE5TEXT__AnalogSerialOutput__, SERVERLINE5TEXT );
    
    SERVERLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE6TEXT__AnalogSerialOutput__, SERVERLINE6TEXT );
    
    SERVERLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE7TEXT__AnalogSerialOutput__, SERVERLINE7TEXT );
    
    SERVERLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERLINE8TEXT__AnalogSerialOutput__, SERVERLINE8TEXT );
    
    SERVERCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERCURRSONGTEXT__AnalogSerialOutput__, SERVERCURRSONGTEXT );
    
    SERVERCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERCURRARTISTTEXT__AnalogSerialOutput__, SERVERCURRARTISTTEXT );
    
    SERVERCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( SERVERCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SERVERCURRALBUMTEXT__AnalogSerialOutput__, SERVERCURRALBUMTEXT );
    
    IPODUSBLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLISTLAYER__AnalogSerialOutput__, IPODUSBLISTLAYER );
    
    IPODUSBLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLISTNAME__AnalogSerialOutput__, IPODUSBLISTNAME );
    
    IPODUSBLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE1TEXT__AnalogSerialOutput__, IPODUSBLINE1TEXT );
    
    IPODUSBLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE2TEXT__AnalogSerialOutput__, IPODUSBLINE2TEXT );
    
    IPODUSBLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE3TEXT__AnalogSerialOutput__, IPODUSBLINE3TEXT );
    
    IPODUSBLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE4TEXT__AnalogSerialOutput__, IPODUSBLINE4TEXT );
    
    IPODUSBLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE5TEXT__AnalogSerialOutput__, IPODUSBLINE5TEXT );
    
    IPODUSBLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE6TEXT__AnalogSerialOutput__, IPODUSBLINE6TEXT );
    
    IPODUSBLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE7TEXT__AnalogSerialOutput__, IPODUSBLINE7TEXT );
    
    IPODUSBLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBLINE8TEXT__AnalogSerialOutput__, IPODUSBLINE8TEXT );
    
    IPODUSBCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBCURRSONGTEXT__AnalogSerialOutput__, IPODUSBCURRSONGTEXT );
    
    IPODUSBCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBCURRARTISTTEXT__AnalogSerialOutput__, IPODUSBCURRARTISTTEXT );
    
    IPODUSBCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODUSBCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODUSBCURRALBUMTEXT__AnalogSerialOutput__, IPODUSBCURRALBUMTEXT );
    
    SIRIUSXMLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLISTLAYER__AnalogSerialOutput__, SIRIUSXMLISTLAYER );
    
    SIRIUSXMLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLISTNAME__AnalogSerialOutput__, SIRIUSXMLISTNAME );
    
    SIRIUSXMLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE1TEXT__AnalogSerialOutput__, SIRIUSXMLINE1TEXT );
    
    SIRIUSXMLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE2TEXT__AnalogSerialOutput__, SIRIUSXMLINE2TEXT );
    
    SIRIUSXMLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE3TEXT__AnalogSerialOutput__, SIRIUSXMLINE3TEXT );
    
    SIRIUSXMLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE4TEXT__AnalogSerialOutput__, SIRIUSXMLINE4TEXT );
    
    SIRIUSXMLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE5TEXT__AnalogSerialOutput__, SIRIUSXMLINE5TEXT );
    
    SIRIUSXMLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE6TEXT__AnalogSerialOutput__, SIRIUSXMLINE6TEXT );
    
    SIRIUSXMLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE7TEXT__AnalogSerialOutput__, SIRIUSXMLINE7TEXT );
    
    SIRIUSXMLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMLINE8TEXT__AnalogSerialOutput__, SIRIUSXMLINE8TEXT );
    
    SIRIUSXMCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMCURRSONGTEXT__AnalogSerialOutput__, SIRIUSXMCURRSONGTEXT );
    
    SIRIUSXMCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMCURRARTISTTEXT__AnalogSerialOutput__, SIRIUSXMCURRARTISTTEXT );
    
    SIRIUSXMCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMCURRALBUMTEXT__AnalogSerialOutput__, SIRIUSXMCURRALBUMTEXT );
    
    SIRIUSXMCURRCHANNELTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSXMCURRCHANNELTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSXMCURRCHANNELTEXT__AnalogSerialOutput__, SIRIUSXMCURRCHANNELTEXT );
    
    RHAPLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( RHAPLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLISTLAYER__AnalogSerialOutput__, RHAPLISTLAYER );
    
    RHAPLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( RHAPLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLISTNAME__AnalogSerialOutput__, RHAPLISTNAME );
    
    RHAPLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE1TEXT__AnalogSerialOutput__, RHAPLINE1TEXT );
    
    RHAPLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE2TEXT__AnalogSerialOutput__, RHAPLINE2TEXT );
    
    RHAPLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE3TEXT__AnalogSerialOutput__, RHAPLINE3TEXT );
    
    RHAPLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE4TEXT__AnalogSerialOutput__, RHAPLINE4TEXT );
    
    RHAPLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE5TEXT__AnalogSerialOutput__, RHAPLINE5TEXT );
    
    RHAPLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE6TEXT__AnalogSerialOutput__, RHAPLINE6TEXT );
    
    RHAPLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE7TEXT__AnalogSerialOutput__, RHAPLINE7TEXT );
    
    RHAPLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE8TEXT__AnalogSerialOutput__, RHAPLINE8TEXT );
    
    RHAPCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPCURRSONGTEXT__AnalogSerialOutput__, RHAPCURRSONGTEXT );
    
    RHAPCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPCURRARTISTTEXT__AnalogSerialOutput__, RHAPCURRARTISTTEXT );
    
    RHAPCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPCURRALBUMTEXT__AnalogSerialOutput__, RHAPCURRALBUMTEXT );
    
    AIRPLAYLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( AIRPLAYLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AIRPLAYLISTLAYER__AnalogSerialOutput__, AIRPLAYLISTLAYER );
    
    AIRPLAYCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( AIRPLAYCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AIRPLAYCURRARTISTTEXT__AnalogSerialOutput__, AIRPLAYCURRARTISTTEXT );
    
    AIRPLAYCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( AIRPLAYCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AIRPLAYCURRSONGTEXT__AnalogSerialOutput__, AIRPLAYCURRSONGTEXT );
    
    AIRPLAYCURRCOMPTEXT = new Crestron.Logos.SplusObjects.StringOutput( AIRPLAYCURRCOMPTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AIRPLAYCURRCOMPTEXT__AnalogSerialOutput__, AIRPLAYCURRCOMPTEXT );
    
    AIRPLAY_VOL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( AIRPLAY_VOL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AIRPLAY_VOL_TEXT__AnalogSerialOutput__, AIRPLAY_VOL_TEXT );
    
    RS232FROMDEV = new Crestron.Logos.SplusObjects.BufferInput( RS232FROMDEV__AnalogSerialInput__, 65534, this );
    m_StringInputList.Add( RS232FROMDEV__AnalogSerialInput__, RS232FROMDEV );
    
    CLIENTSOCKETPORT = new UShortParameter( CLIENTSOCKETPORT__Parameter__, this );
    m_ParameterList.Add( CLIENTSOCKETPORT__Parameter__, CLIENTSOCKETPORT );
    
    CLIENTSOCKETADDRESS = new StringParameter( CLIENTSOCKETADDRESS__Parameter__, this );
    m_ParameterList.Add( CLIENTSOCKETADDRESS__Parameter__, CLIENTSOCKETADDRESS );
    
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    
    CONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECT_OnPush_0, false ) );
    CMDIN.OnSerialChange.Add( new InputChangeHandlerWrapper( CMDIN_OnChange_1, false ) );
    TUNERDIRVAL.OnAnalogChange.Add( new InputChangeHandlerWrapper( TUNERDIRVAL_OnChange_2, false ) );
    RS232FROMDEV.OnSerialChange.Add( new InputChangeHandlerWrapper( RS232FROMDEV_OnChange_3, false ) );
    CLIENTSOCKET.OnSocketConnect.Add( new SocketHandlerWrapper( CLIENTSOCKET_OnSocketConnect_4, false ) );
    CLIENTSOCKET.OnSocketDisconnect.Add( new SocketHandlerWrapper( CLIENTSOCKET_OnSocketDisconnect_5, false ) );
    CLIENTSOCKET.OnSocketStatus.Add( new SocketHandlerWrapper( CLIENTSOCKET_OnSocketStatus_6, false ) );
    CLIENTSOCKET.OnSocketReceive.Add( new SocketHandlerWrapper( CLIENTSOCKET_OnSocketReceive_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_YAMAHA_RX_A820_COMMAND___FB_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;


const uint CONNECT__DigitalInput__ = 0;
const uint CMDIN__AnalogSerialInput__ = 0;
const uint RS232FROMDEV__AnalogSerialInput__ = 1;
const uint TUNERISFM__DigitalInput__ = 1;
const uint TUNERISAM__DigitalInput__ = 2;
const uint TUNERDIRVAL__AnalogSerialInput__ = 2;
const uint CONNECTED__DigitalOutput__ = 0;
const uint RXPROCESSED__AnalogSerialOutput__ = 0;
const uint RS232_TO_DEV__AnalogSerialOutput__ = 1;
const uint MAIN_ZONE_NAME__AnalogSerialOutput__ = 2;
const uint MAIN_SCENE1_NAME__AnalogSerialOutput__ = 3;
const uint MAIN_SCENE2_NAME__AnalogSerialOutput__ = 4;
const uint MAIN_SCENE3_NAME__AnalogSerialOutput__ = 5;
const uint MAIN_SCENE4_NAME__AnalogSerialOutput__ = 6;
const uint MAIN_SCENE5_NAME__AnalogSerialOutput__ = 7;
const uint MAIN_SCENE6_NAME__AnalogSerialOutput__ = 8;
const uint MAIN_SCENE7_NAME__AnalogSerialOutput__ = 9;
const uint MAIN_SCENE8_NAME__AnalogSerialOutput__ = 10;
const uint MAIN_SCENE9_NAME__AnalogSerialOutput__ = 11;
const uint MAIN_SCENE10_NAME__AnalogSerialOutput__ = 12;
const uint MAIN_SCENE11_NAME__AnalogSerialOutput__ = 13;
const uint MAIN_SCENE12_NAME__AnalogSerialOutput__ = 14;
const uint MAIN_SLEEP_TIMER_TEXT__AnalogSerialOutput__ = 15;
const uint MAIN_VOL_TEXT__AnalogSerialOutput__ = 16;
const uint MAIN_CURR_INPUT_AUDIO_TYPE__AnalogSerialOutput__ = 17;
const uint MAIN_DECODER_MODE__AnalogSerialOutput__ = 18;
const uint MAIN_PURE_DIRECT_MODE__AnalogSerialOutput__ = 19;
const uint MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE__AnalogSerialOutput__ = 20;
const uint MAIN_LIP_SYNC_MODE__AnalogSerialOutput__ = 21;
const uint MAIN_STRAIGHT_MODE_STATUS__AnalogSerialOutput__ = 22;
const uint MAIN_ENHANCER_STATUS__AnalogSerialOutput__ = 23;
const uint MAIN_SOUND_PROG_STATUS__AnalogSerialOutput__ = 24;
const uint MAIN_ADAPTIVE_DSP_MODE__AnalogSerialOutput__ = 25;
const uint MAIN_3D_CINEMA_MODE__AnalogSerialOutput__ = 26;
const uint MAIN_EX_DECODER_MODE__AnalogSerialOutput__ = 27;
const uint MAIN_2CHAN_DECODER_MODE__AnalogSerialOutput__ = 28;
const uint MAIN_CURR_HDMI_OUT_CONFIG__AnalogSerialOutput__ = 29;
const uint MAIN_HDMI_PROC_STATE__AnalogSerialOutput__ = 30;
const uint MAIN_HDMI_ASPECT__AnalogSerialOutput__ = 31;
const uint MAIN_HDMI_RES__AnalogSerialOutput__ = 32;
const uint ZONE2_NAME__AnalogSerialOutput__ = 33;
const uint ZONE2_SCENE1_NAME__AnalogSerialOutput__ = 34;
const uint ZONE2_SCENE2_NAME__AnalogSerialOutput__ = 35;
const uint ZONE2_SCENE3_NAME__AnalogSerialOutput__ = 36;
const uint ZONE2_SCENE4_NAME__AnalogSerialOutput__ = 37;
const uint ZONE2_SLEEP_TIMER_TEXT__AnalogSerialOutput__ = 38;
const uint ZONE2_VOL_TEXT__AnalogSerialOutput__ = 39;
const uint TUNER_CURR_STATION__AnalogSerialOutput__ = 40;
const uint TUNER_FM_MODE__AnalogSerialOutput__ = 41;
const uint NETRADIOLISTLAYER__AnalogSerialOutput__ = 42;
const uint NETRADIOLISTNAME__AnalogSerialOutput__ = 43;
const uint NETRADIOLINE1TEXT__AnalogSerialOutput__ = 44;
const uint NETRADIOLINE2TEXT__AnalogSerialOutput__ = 45;
const uint NETRADIOLINE3TEXT__AnalogSerialOutput__ = 46;
const uint NETRADIOLINE4TEXT__AnalogSerialOutput__ = 47;
const uint NETRADIOLINE5TEXT__AnalogSerialOutput__ = 48;
const uint NETRADIOLINE6TEXT__AnalogSerialOutput__ = 49;
const uint NETRADIOLINE7TEXT__AnalogSerialOutput__ = 50;
const uint NETRADIOLINE8TEXT__AnalogSerialOutput__ = 51;
const uint NETRADIOCURRSONGTEXT__AnalogSerialOutput__ = 52;
const uint NETRADIOCURRARTISTTEXT__AnalogSerialOutput__ = 53;
const uint NETRADIOCURRALBUMTEXT__AnalogSerialOutput__ = 54;
const uint NETRADIOCURRCHANNELTEXT__AnalogSerialOutput__ = 55;
const uint PANDLISTLAYER__AnalogSerialOutput__ = 56;
const uint PANDLISTNAME__AnalogSerialOutput__ = 57;
const uint PANDLINE1TEXT__AnalogSerialOutput__ = 58;
const uint PANDLINE2TEXT__AnalogSerialOutput__ = 59;
const uint PANDLINE3TEXT__AnalogSerialOutput__ = 60;
const uint PANDLINE4TEXT__AnalogSerialOutput__ = 61;
const uint PANDLINE5TEXT__AnalogSerialOutput__ = 62;
const uint PANDLINE6TEXT__AnalogSerialOutput__ = 63;
const uint PANDLINE7TEXT__AnalogSerialOutput__ = 64;
const uint PANDLINE8TEXT__AnalogSerialOutput__ = 65;
const uint PANDCURRSONGTEXT__AnalogSerialOutput__ = 66;
const uint PANDCURRALBUMTEXT__AnalogSerialOutput__ = 67;
const uint PANDCURRSTATIONTEXT__AnalogSerialOutput__ = 68;
const uint USBLISTLAYER__AnalogSerialOutput__ = 69;
const uint USBLISTNAME__AnalogSerialOutput__ = 70;
const uint USBLINE1TEXT__AnalogSerialOutput__ = 71;
const uint USBLINE2TEXT__AnalogSerialOutput__ = 72;
const uint USBLINE3TEXT__AnalogSerialOutput__ = 73;
const uint USBLINE4TEXT__AnalogSerialOutput__ = 74;
const uint USBLINE5TEXT__AnalogSerialOutput__ = 75;
const uint USBLINE6TEXT__AnalogSerialOutput__ = 76;
const uint USBLINE7TEXT__AnalogSerialOutput__ = 77;
const uint USBLINE8TEXT__AnalogSerialOutput__ = 78;
const uint USBCURRSONGTEXT__AnalogSerialOutput__ = 79;
const uint USBCURRARTISTTEXT__AnalogSerialOutput__ = 80;
const uint USBCURRALBUMTEXT__AnalogSerialOutput__ = 81;
const uint SERVERLISTLAYER__AnalogSerialOutput__ = 82;
const uint SERVERLISTNAME__AnalogSerialOutput__ = 83;
const uint SERVERLINE1TEXT__AnalogSerialOutput__ = 84;
const uint SERVERLINE2TEXT__AnalogSerialOutput__ = 85;
const uint SERVERLINE3TEXT__AnalogSerialOutput__ = 86;
const uint SERVERLINE4TEXT__AnalogSerialOutput__ = 87;
const uint SERVERLINE5TEXT__AnalogSerialOutput__ = 88;
const uint SERVERLINE6TEXT__AnalogSerialOutput__ = 89;
const uint SERVERLINE7TEXT__AnalogSerialOutput__ = 90;
const uint SERVERLINE8TEXT__AnalogSerialOutput__ = 91;
const uint SERVERCURRSONGTEXT__AnalogSerialOutput__ = 92;
const uint SERVERCURRARTISTTEXT__AnalogSerialOutput__ = 93;
const uint SERVERCURRALBUMTEXT__AnalogSerialOutput__ = 94;
const uint IPODUSBLISTLAYER__AnalogSerialOutput__ = 95;
const uint IPODUSBLISTNAME__AnalogSerialOutput__ = 96;
const uint IPODUSBLINE1TEXT__AnalogSerialOutput__ = 97;
const uint IPODUSBLINE2TEXT__AnalogSerialOutput__ = 98;
const uint IPODUSBLINE3TEXT__AnalogSerialOutput__ = 99;
const uint IPODUSBLINE4TEXT__AnalogSerialOutput__ = 100;
const uint IPODUSBLINE5TEXT__AnalogSerialOutput__ = 101;
const uint IPODUSBLINE6TEXT__AnalogSerialOutput__ = 102;
const uint IPODUSBLINE7TEXT__AnalogSerialOutput__ = 103;
const uint IPODUSBLINE8TEXT__AnalogSerialOutput__ = 104;
const uint IPODUSBCURRSONGTEXT__AnalogSerialOutput__ = 105;
const uint IPODUSBCURRARTISTTEXT__AnalogSerialOutput__ = 106;
const uint IPODUSBCURRALBUMTEXT__AnalogSerialOutput__ = 107;
const uint SIRIUSXMLISTLAYER__AnalogSerialOutput__ = 108;
const uint SIRIUSXMLISTNAME__AnalogSerialOutput__ = 109;
const uint SIRIUSXMLINE1TEXT__AnalogSerialOutput__ = 110;
const uint SIRIUSXMLINE2TEXT__AnalogSerialOutput__ = 111;
const uint SIRIUSXMLINE3TEXT__AnalogSerialOutput__ = 112;
const uint SIRIUSXMLINE4TEXT__AnalogSerialOutput__ = 113;
const uint SIRIUSXMLINE5TEXT__AnalogSerialOutput__ = 114;
const uint SIRIUSXMLINE6TEXT__AnalogSerialOutput__ = 115;
const uint SIRIUSXMLINE7TEXT__AnalogSerialOutput__ = 116;
const uint SIRIUSXMLINE8TEXT__AnalogSerialOutput__ = 117;
const uint SIRIUSXMCURRSONGTEXT__AnalogSerialOutput__ = 118;
const uint SIRIUSXMCURRARTISTTEXT__AnalogSerialOutput__ = 119;
const uint SIRIUSXMCURRALBUMTEXT__AnalogSerialOutput__ = 120;
const uint SIRIUSXMCURRCHANNELTEXT__AnalogSerialOutput__ = 121;
const uint RHAPLISTLAYER__AnalogSerialOutput__ = 122;
const uint RHAPLISTNAME__AnalogSerialOutput__ = 123;
const uint RHAPLINE1TEXT__AnalogSerialOutput__ = 124;
const uint RHAPLINE2TEXT__AnalogSerialOutput__ = 125;
const uint RHAPLINE3TEXT__AnalogSerialOutput__ = 126;
const uint RHAPLINE4TEXT__AnalogSerialOutput__ = 127;
const uint RHAPLINE5TEXT__AnalogSerialOutput__ = 128;
const uint RHAPLINE6TEXT__AnalogSerialOutput__ = 129;
const uint RHAPLINE7TEXT__AnalogSerialOutput__ = 130;
const uint RHAPLINE8TEXT__AnalogSerialOutput__ = 131;
const uint RHAPCURRSONGTEXT__AnalogSerialOutput__ = 132;
const uint RHAPCURRARTISTTEXT__AnalogSerialOutput__ = 133;
const uint RHAPCURRALBUMTEXT__AnalogSerialOutput__ = 134;
const uint AIRPLAYLISTLAYER__AnalogSerialOutput__ = 135;
const uint AIRPLAYCURRARTISTTEXT__AnalogSerialOutput__ = 136;
const uint AIRPLAYCURRSONGTEXT__AnalogSerialOutput__ = 137;
const uint AIRPLAYCURRCOMPTEXT__AnalogSerialOutput__ = 138;
const uint AIRPLAY_VOL_TEXT__AnalogSerialOutput__ = 139;
const uint CLIENTSOCKETADDRESS__Parameter__ = 10;
const uint CLIENTSOCKETPORT__Parameter__ = 11;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort G_BPARSING = 0;
            [SplusStructAttribute(1, false, true)]
            public short CLIENTSOCKETSTATUS = 0;
            [SplusStructAttribute(2, false, true)]
            public CrestronString CMDTOSEND;
            [SplusStructAttribute(3, false, true)]
            public CrestronString G_SDATA;
            
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
