# Departmental-Store
## Case Study Scenario
Miss Client wants to develop a software system for her departmental store. She wants this
system to have the following functionalities.
As an Admin, she can

    Add Products 

        ● View All Products.
        ● Find Product with Highest Unit Price.
        ● View Sales Tax of All Products.
        ● Products to be Ordered. (less than threshold)

Following is the information that is required to save for the product.
Name of Product. Product Category. Product Price. Available Stock Quantity. Minimum
Stock threshold Quantity after which the owner wants to order the product.
On All Grocery type of products, the sales tax is 10%, on all fruit types the tax is 5% and
if there is any other type the tax is 15%

    She also wants that

        1. The Customers to view all the products
        2. Customers can buy the products (When a customer buy a product then its quantity should decrease from the stock)
        3. Generate invoice (While calculating the price of the products that the customer has bought, sales tax should be applied.)
Make 3 classes

    1. Product
    2. Customer
    3. MUser (or credentials) that we have previously developed with file handling

## Domain Model
### Class name
![class](https://user-images.githubusercontent.com/96945594/181287406-2b8e40e4-8a10-4ac1-b857-3b76506d990c.jpg)
### Relations and Constraints
![relation](https://user-images.githubusercontent.com/96945594/181287395-ec6dbb58-404f-4f5c-b234-2af540864463.png)
### Multiplicity
![constrain](https://user-images.githubusercontent.com/96945594/181287409-d91588d6-4974-4dde-be70-8ecd7ce71059.jpg)
### Attributes and Function
#### Business Logic Layer
![bl](https://user-images.githubusercontent.com/96945594/181287697-5eb0e020-6fad-42aa-9e9d-c8e21df5120d.JPG)
#### Data Layer
![dl](https://user-images.githubusercontent.com/96945594/181287702-75a9c9f1-3f54-405a-b021-1d8007110a2a.JPG)
#### User Interfaces Layer
![ul](https://user-images.githubusercontent.com/96945594/181287681-54bd5e9b-1b9c-4957-89ee-79a14820ee1c.JPG)

