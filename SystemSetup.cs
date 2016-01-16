using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViberationScope
{
    class SystemSetup
    {
        static SystemSetup _instance=null;
        public DeviceSetup dev_Setup;
        public static SystemSetup getInstance()
        {
            if (null == _instance)
            {
                _instance = new SystemSetup();
            }
            return _instance;
        }
        public void init()
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(DeviceSetup));
            System.IO.FileStream in_strm = new System.IO.FileStream("DeviceSetup.xml", System.IO.FileMode.OpenOrCreate);
            try
            {
                dev_Setup = ser.Deserialize(in_strm) as DeviceSetup;
            }
            catch (Exception ex)
            { }
            finally
            {
                in_strm.Close();
            }
            if (dev_Setup == null)
            {
                dev_Setup = new DeviceSetup();
            }

        }
        public void save()
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(DeviceSetup));
            System.IO.FileStream os = new System.IO.FileStream("DeviceSetup.xml", System.IO.FileMode.Create);
            try
            {
                ser.Serialize(os, dev_Setup);
            }
            catch (Exception ex)
            { }
            finally
            {
                os.Close();
            }
        }
    }

    public class DeviceSetup
    {
        int _BaudRate = 19200;
        public int BaudRate
        {
            get { return _BaudRate; }
            set { _BaudRate = value; }
        }
        UInt32 _NumFFT = 4096;
        public UInt32 NumFFT
        {
            get { return _NumFFT; }
            set { _NumFFT = value; }
        }
        string _DevPortName = "";
        public String DevPortName
        {
            get { return _DevPortName; }
            set { _DevPortName = value; }
        }
        string _DataPath = "";
        public String DataPath
        {
            get { return _DataPath; }
            set { _DataPath = value; }
        }
    }
}
