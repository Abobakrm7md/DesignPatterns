//Converts the interface of a class into another interface the client expects.
//Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

using AdapterPattern.Adaptee;
using AdapterPattern.AdapterInterface;
using AdapterPattern.Adapters;

ITarget target = new AdapterClass();
target.Request(12);

AdapteeCode adapteeCode = new AdapteeCode();
ITarget adapteeTarget = new AdapterClass();
adapteeTarget.Request(13);