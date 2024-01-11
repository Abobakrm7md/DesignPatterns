//Strategy is a
//behavioral design pattern that lets you define
//a family of algorithms, put each of them into a separate class,
//and make their objects interchangeable.

using StrategyPattern.Context;
using StrategyPattern.ResponseModel;
using StrategyPattern.StrategiesAlgorithmes;

StrategyContext context = new StrategyContext(new SearchPlacesAlgorithm());
var places = context.GetResponse<PlacesObject>();
foreach (var place in places.places)
    Console.WriteLine(place.address);
context.SetStrategy(new SearchImagesAlgorithm());
var images =  context.GetResponse<ImagesResponse>();
foreach (var image in images.images)
    Console.WriteLine(image.imageUrl);