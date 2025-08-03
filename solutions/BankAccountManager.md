📊 **Score: 9/10**

---

### ✅ What went well

* **✅ Program compiles and runs without errors**
* **✅ Uses a `BankAccount` class with fields, constructor, and methods**
* **✅ Menu interaction with `Console.ReadKey()` works cleanly**
* **✅ Input is validated using `decimal.TryParse()`**
* **✅ Withdraw logic protects against overdraft**
* **✅ Deposit logic rejects zero/negative input**
* **✅ Separation of concerns — class in its own file**
* **✅ Uses namespace properly (`BankAccountManager`)**

---

### 📌 What could be improved

* **\[–1] Input logic allows execution after invalid input.**
  If parsing fails, you still call `Deposit()` or `Withdraw()` — even with garbage data:

  ```csharp
  if (!decimal.TryParse(inputDeposit, out depositAmount))
  {
      Console.WriteLine("please enter a valid number");
  }
  account.Deposit(depositAmount); // ← still runs
  ```

  ✅ **Fix**: Add `else` or return early.

  ```csharp
  if (!decimal.TryParse(inputDeposit, out depositAmount))
  {
      Console.WriteLine("Invalid number");
      break;
  }
  ```

* **Minor style things:**

  * `owner` should ideally be `Owner` (PascalCase for public fields or use a property)
  * Consider removing the `else` after `return` in `Withdraw` (style preference)

---

### ✅ Points Breakdown

| Points   | Description                                                    |
| -------- | -------------------------------------------------------------- |
| +5       | Program builds and meets all required criteria                 |
| +1       | Clean structure (separate class, proper Main loop)             |
| +1       | Input validation & safe balance handling                       |
| +1       | Console UX is responsive and readable                          |
| +1       | Stretch goal: prevents invalid withdrawals & negative deposits |
| **–1**   | Minor logic flaw: continues after invalid input                |
| **9/10** | **Total**                                                      |

---

### 🧠 Suggestions for stretch

* Add transaction history (list of strings)
* Support multiple accounts in a dictionary
* Format balance with currency: `ToString("C")`
