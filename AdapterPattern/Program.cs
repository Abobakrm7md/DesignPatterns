using AdapterPattern.Adaptee;
using AdapterPattern.AdapterInterface;
using AdapterPattern.Adapters;

ITarget target = new AdapterClass();
target.Request(12);

AdapteeCode adapteeCode = new AdapteeCode();
ITarget adapteeTarget = new AdapterClass();
adapteeTarget.Request(13);