# 🍔 Fast Food Restaurant Management System (WinForms)

An interactive, user-friendly Desktop Management System for Fast Food Restaurants built using **C#** and **Windows Forms (WinForms)**. This application provides a seamless experience for cashiers to select food items, drinks, and desserts, calculate real-time pricing with automatic discounts, generate detailed itemized receipts, and process final orders safely.

---

## 🚀 Key Features

* **Dynamic UI Layout:** Well-structured interface separating Fast Meals from Drinks & Desserts with embedded item checkboxes and precise quantity controls (`NumericUpDown`).
* **High-Precision Financial Calculations:** Powered entirely by the `decimal` data type to prevent any floating-point precision errors during subtotals, discounts, and net calculations.
* **Automated Discounting:** Built-in calculation engine that automatically applies a **10% discount** on the grand total upon pricing.
* **Smart Deep-Search Validation:** Custom recursive verification algorithm that dynamically scans all container elements (`Panels` and `GroupBoxes`) to prevent processing empty orders.
* **Itemized Receipt Display:** Clean, un-cluttered real-time billing via a centralized `RichTextBox` component detailing item names, chosen quantities, base single prices, and calculated subtotals.
* **Safe Transaction Process:** Prompt-driven transaction confirmation (Yes/No dialogs) with automatic state reset upon successful checkouts.
* **Global Reset System:** Single-click comprehensive environment sweep that restores all fields, checkboxes, labels, and receipt displays to default values.

---

## 📸 System Screenshots

### 1️⃣ Main Application Interface
*Clean and structured dynamic layout designed for high productivity.*
![Main Interface](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/3c0711b918511604caf77842bbb71aecf3981379/mainPageFastFood%20Restaurant.png)

### 2️⃣ Itemized Receipt & Order Processing
*Detailed itemization breakdown displaying quantities, base prices, and individual subtotals without clutter.*
![Order Receipt](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/3c0711b918511604caf77842bbb71aecf3981379/ReceiptAndOrderPage.png)

### 3️⃣ High-Precision Subtotal & Confirmation Dialog
*Safe financial transactions showing 10% discount calculations with dynamic pop-up prompts.*
![Confirmation Prompt](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/3c0711b918511604caf77842bbb71aecf3981379/High_PrecisionAndConfirmationDialog.png)

---

## 🛠️ Built With

* **Language:** C#
* **Framework:** .NET Framework / .NET Core (Windows Forms)
* **IDE:** Visual Studio 2022
* **Version Control:** Git & GitHub

---

git clone https://github.com//FastFoodRestaurant.git
