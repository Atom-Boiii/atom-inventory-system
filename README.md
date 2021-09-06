<h1>Inventory system made by Hidde Loman</h1>

<h2>The project</h2>
<p>This is a mini project that I did for fun. It uses the unity engine and c#.</p>

<h2>How it works</h2>
<p>I used the default unity UI button. Once something is added to the inventory the script puts it in the nearest empty slot. When the user clicks on the button all information on the button is placed to a special itemslot following the mouse. If the player then clicks on a diffrent button the information is placed in that button. If the button already contains information the information is swapped between the mouse and the item slot.</p>

<h2>Useage</h2>
<p>To use the inventory system you need the "Inventory.cs" script. This makes sure the player has an inventory. This also contains the size, ui elements and all items in the inventory. You will need an inventory ui objectt with a background and a grid layout element. You also need to asign an inventoryItem prefab. This is a button with an image and the "InventoryItem.cs" script. If you assign everything correctly it should make an inventory witht the slots for you.</p>
