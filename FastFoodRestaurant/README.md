<div align="center">

  # 🍔 Fast Food Restaurant Management System (POS)

  **A modern, robust, and secure Desktop Point of Sale (POS) application for Fast Food Restaurants.**

  [![C#](https://img.shields.io/badge/Language-C%23-blue.svg?style=for-the-badge&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
  [![.NET WinForms](https://img.shields.io/badge/Framework-.NET%20WinForms-512BD4.svg?style=for-the-badge&logo=dotnet)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
  [![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91.svg?style=for-the-badge&logo=visual-studio)](https://visualstudio.microsoft.com/)
  [![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)

</div>

---

## 📌 Overview

The **Fast Food Restaurant Management System** is an interactive, high-precision Point of Sale (POS) desktop application engineered using **C#** and **Windows Forms (WinForms)**. Designed for speed, security, and accuracy, it empowers cashiers to handle real-time meal assembly, dynamic order fulfillment (Dine-In, Delivery, Takeaway), flexible multi-channel payment processing, and automated tamper-proof daily receipt logging.

---

## 🚀 Key Features & Highlights

* **Dynamic Order Type Tracking:**
  * **Dine-In:** Tracks and records dynamic table numbers.
  * **Delivery:** Captures customer contact numbers directly onto receipts.
  * **Takeaway:** Fast-track billing for express counter orders.

* **Multi-Channel Payment Processing:**
  * **Cash:** Calculates amount paid vs. customer balance/change with strict validation against underpayment.
  * **Card Operations:** Integrated support for Unified Network, Visa, and Mastercard with reference transaction ID tracking.
  * **E-Wallets:** Local and regional digital wallet integration (Jaib, ONE Cash, Jawali, Kuraimi, Floosak) with transaction verification.

* **Automated Daily Isolated Receipt Logging:**
  * Automatically isolates and generates dedicated daily transaction files (`Receipts_YYYY-MM-DD.txt`) directly on the Desktop.
  * Preserves formatted receipt details including timestamps, payment methods, transaction IDs, order types, itemized quantities, sub-totals, discounts, and net totals.

* **Tamper-Proof File Security:**
  * Programmatically applies system `ReadOnly` file attributes (`FileAttributes.ReadOnly`) immediately after writing each receipt to prevent unauthorized modification by line staff.

* **High-Precision Financial Calculations:**
  * Powered entirely by the C# `decimal` data type to eliminate floating-point rounding errors during subtotal aggregation, automatic **10% discount** applications, and net calculations.

* **Smart UI & Deep-Search Validation:**
  * Recursive control scanning across containers (`Panels` & `GroupBoxes`) prevents processing empty orders.
  * Form auto-resetting clears input fields and checkboxes immediately after verified order completion.

---

## 📸 System Walkthrough & Screenshots

### 1️⃣ Main Cashier POS Interface
*Interactive dashboard supporting Fast Meals, Beverages, Desserts, real-time receipt preview, live clock, and dynamic Order Type options (Dine-In Table tracking).*
![Main Cashier Interface](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Main-Cashier-Interface.png)

---

### 2️⃣ Cash Payment Processing & Change Calculation
*Dedicated Cash tab with automated calculation of customer change and remaining balance.*
![Cash Payment](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Cash-Payment.png)

---

### 3️⃣ Credit / Debit Card Payment Gateway
*Supports card networks (Unified Network, Visa Card, MasterCard) along with mandatory operation transaction ID validation.*
![Card Payment Gateway](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Card-Payment-Gateway.png)

---

### 4️⃣ E-Wallet Transaction Processing
*Seamless integration with local mobile wallets (Jaib, ONE Cash, Jawali, Kuraimi, Floosak) requiring reference number logging.*
![E-Wallet Options](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/E-Wallet-Options.png)

---

### 5️⃣ Transaction Confirmation Notice
*Real-time dialog confirming successful payment authorization, exact amount received, wallet provider, and transaction ID.*
![Success Notification](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Success-Notification.png)

---

### 6️⃣ Underpayment Safeguard & Automatic State Reset  
*Built-in system alerts preventing invalid transactions (e.g., insufficient cash) and automated form clearing upon successful checkout.*
<p float="left">
  <img src="https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Underpayment-Safeguard.png" width="48%" />
  <img src="https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Automatic-State-Reset.png" width="48%" />
</p>

---

### 7️⃣ Isolated & Secured Receipt File Log (`.txt`)
*Sample of the auto-generated daily receipt file created on the Desktop, formatted with strict column alignment and protected with Read-Only system attributes.*
![Secured Daily Receipt Log](https://raw.githubusercontent.com/AbuAlwah/FastFoodRestaurant/1144be2e12fb182cd703062a03a59ffb94dac824/Secured-Receipt-File-Log.png)

---

## 🛠️ System Architecture & Technology Stack

* **Programming Language:** C# 10 / .NET Framework
* **UI Framework:** Windows Forms (WinForms)
* **Storage & File I/O:** Programmatic `StreamWriter` with system file attribute manipulation (`FileAttributes.ReadOnly`)
* **IDE:** Visual Studio 2022
* **Version Control:** Git / GitHub

---

## ⚙️ Installation & Getting Started

1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/AbuAlwah/FastFoodRestaurant.git](https://github.com/AbuAlwah/FastFoodRestaurant.git)