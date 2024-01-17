using ProxyPattern.Proxy.CacheType;

//The Proxy Pattern is a structural design pattern that provides a
//surrogate or placeholder for another object to control access to it. 

//Virtual Proxy: A proxy that controls access to an object that is expensive to instantiate.
//Protection Proxy: A proxy that controls access to methods or operations of the real object, providing additional security checks.
//Remote Proxy: A proxy that acts as a local representation of an object that is in a different address space (e.g., on a different server).
//It handles communication and data transfer between the local and remote objects.
//Cache Proxy: A proxy that keeps a cache of the results of expensive operations on the real object and returns the cached result when the same operations are requested.

#region cache proxy
ImageProxy imageProxy1 = new ImageProxy("Image.jpg");
ImageProxy imageProxy2 = new ImageProxy("Image1.jpg");

imageProxy1.Display();
imageProxy2.Display();

Console.WriteLine("-----------------------------------------");

imageProxy1.Display();
imageProxy2.Display();

ImageProxy imageProxy3 = new ImageProxy("Image.jpg");
ImageProxy imageProxy4 = new ImageProxy("Image1.jpg");
ImageProxy imageProxy5 = new ImageProxy("Image.jpg");
imageProxy3.Display();
imageProxy4.Display();
imageProxy5.Display();
#endregion

//#region Virtual
//ProxyPattern.Proxy.Virtual.ImageProxy imageProxy12 = new ProxyPattern.Proxy.Virtual.ImageProxy("Image.jpg");
//imageProxy12.Display();
//imageProxy12.Display();

//#endregion