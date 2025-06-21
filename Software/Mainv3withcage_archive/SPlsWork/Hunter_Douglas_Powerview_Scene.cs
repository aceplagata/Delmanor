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

namespace UserModule_HUNTER_DOUGLAS_POWERVIEW_SCENE
{
    public class UserModuleClass_HUNTER_DOUGLAS_POWERVIEW_SCENE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput EXECUTE_SCENE;
        Crestron.Logos.SplusObjects.StringOutput TO_HUB;
        StringParameter SCENE_NAME;
        object EXECUTE_SCENE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 153;
                TO_HUB  .UpdateValue ( SCENE_NAME  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        EXECUTE_SCENE = new Crestron.Logos.SplusObjects.DigitalInput( EXECUTE_SCENE__DigitalInput__, this );
        m_DigitalInputList.Add( EXECUTE_SCENE__DigitalInput__, EXECUTE_SCENE );
        
        TO_HUB = new Crestron.Logos.SplusObjects.StringOutput( TO_HUB__AnalogSerialOutput__, this );
        m_StringOutputList.Add( TO_HUB__AnalogSerialOutput__, TO_HUB );
        
        SCENE_NAME = new StringParameter( SCENE_NAME__Parameter__, this );
        m_ParameterList.Add( SCENE_NAME__Parameter__, SCENE_NAME );
        
        
        EXECUTE_SCENE.OnDigitalPush.Add( new InputChangeHandlerWrapper( EXECUTE_SCENE_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_HUNTER_DOUGLAS_POWERVIEW_SCENE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint EXECUTE_SCENE__DigitalInput__ = 0;
    const uint TO_HUB__AnalogSerialOutput__ = 0;
    const uint SCENE_NAME__Parameter__ = 10;
    
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
