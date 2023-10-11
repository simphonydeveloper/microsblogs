## DataStore DbKey writes data.

In newer versions, DbKey supports initializing objects with IDs.

```c#
 public class PropertyID : BaseDbKey<int>, IXmlSerializable
        {
            public PropertyID();
            public PropertyID(PropertyID p);
            public PropertyID(int val);

            public PropertyID Copy();
            public XmlSchema GetSchema();
            public void ReadXml(XmlReader reader);
            public void WriteXml(XmlWriter writer);
        }
```

However, in older versions such as 18+and 2.9+.

```c#
 public class PropertyID : BaseDbKey<int>, IXmlSerializable
        {
            public PropertyID();
            public PropertyID(PropertyID p);

            public PropertyID Copy();
            public XmlSchema GetSchema();
            public void ReadXml(XmlReader reader);
            public void WriteXml(XmlWriter writer);
        }
```

You can easily handle it in 19.3.

```c#
 var dbProperty = DataStore.ReadPropertyByID(property);
```



If your extensibility needs to be used in multiple versions, I suggest doing so.

```c#
       [ExtensibilityMethod]
        public void Part8Test1()
        {
            Logger.LogAlways("Part8Test1");


            var property = new DbKey.PropertyID();
            string xml = $"<value>21</value>";
            Logger.LogAlways(xml);

            StringReader sr = new StringReader(xml);
            var reader = XmlReader.Create(sr);
            reader.ReadToFollowing("value");
            property.ReadXml(reader);
            Logger.LogAlways("read success " + property.Value);

            var dbProperty = DataStore.ReadPropertyByID(property);
            Logger.LogAlways(dbProperty.PropertyID.ToString());
        }
```

