# SavingSystem
A flexible saving system for storing and restoring data.

We are using newtonsoft json for serializing and deserializing. Make sure you import the asset into your project:
https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347


* Implement the ISaveable interface:
* Create a new instance of the SaveAdapter
* Call save and load wherever you want to save / restore the data

Example for Gold (int)
Define the interface:

![image](https://user-images.githubusercontent.com/66161323/116825545-191e7980-ab90-11eb-9e56-579eab422ed0.png)

Implement the interface:

![image](https://user-images.githubusercontent.com/66161323/116825630-6569b980-ab90-11eb-9046-d83bca7bb5e3.png)

Create a new instance of the SaveAdapter:

![image](https://user-images.githubusercontent.com/66161323/116825716-b2e62680-ab90-11eb-8d4f-a55d230f039a.png)

Save and load from where ever you want:

![image](https://user-images.githubusercontent.com/66161323/116825893-9a2a4080-ab91-11eb-9a38-8777374c5f04.png)


Example for player position (vector3)
Define the interface:

![image](https://user-images.githubusercontent.com/66161323/116825600-466b2780-ab90-11eb-86d5-78776023cc5c.png)

Implement the interface:

![image](https://user-images.githubusercontent.com/66161323/116825819-28ea8d80-ab91-11eb-96be-98a244caed48.png)

Create a new instance of the SaveAdapter:

![image](https://user-images.githubusercontent.com/66161323/116825709-a95cbe80-ab90-11eb-965e-03cfd9ccda36.png)

Save and load from where ever you want:

![image](https://user-images.githubusercontent.com/66161323/116825893-9a2a4080-ab91-11eb-9a38-8777374c5f04.png)
