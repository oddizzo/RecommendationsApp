using RecommendationsApp.Modules;

// Display User Information
UserModule userModule = new UserModule();

var users = userModule.getUsers();

Console.WriteLine(" ");
Console.WriteLine("User Info List:");

foreach (var user in users)
{
    Console.WriteLine($"UserId: {user.Id}    UserName: {user.Name}");
}

// Display Product Information
ProductModule productModule = new ProductModule();

var products = productModule.getProducts();

Console.WriteLine(" ");
Console.WriteLine("Product Info List:");

foreach (var product in products)
{
    Console.WriteLine($"ProductId: {product.Id}    ProductName: {product.Name}");
}

// Display User Products Information
UserProductModule userProductModule = new UserProductModule();

var userProducts = userProductModule.GetAllUserProducts();

Console.WriteLine(" ");
Console.WriteLine("User Products List:");

foreach (var userProduct in userProducts)
{
    Console.WriteLine($"User: {userModule.getUserById(userProduct.UserId).Name}    Product: {productModule.getProductById(userProduct.ProductId).Name}");
}

// Enter a UserId from the User Info List
// Get Product Recommendations by UserId 
try
{
    Console.WriteLine(" ");
    Console.WriteLine("Enter a UserId from the User Info List...");
    int userId = Int16.Parse(Console.ReadLine());
    Console.WriteLine($"Get Product Recommendations by UserId: {userId}");

    RecommendationsEngine recommendationsEngine = new RecommendationsEngine(products, users, userProducts);

    var recommendations = recommendationsEngine.Recommend(userId);

    Console.WriteLine(" ");
    Console.WriteLine("Product Recommendation List:");

    foreach (var recommendation in recommendations)
    {
        Console.WriteLine($"ProductName: {recommendation.Name}    ProductCategory: {recommendation.Category}");
    }
}
catch
{
    Console.WriteLine(" ");
    Console.WriteLine("Error, please enter a valid UserId.");
}

