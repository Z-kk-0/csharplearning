📊 **Score: 9/10**

---

### ✅ What went well

* **✅ Builds and runs successfully**
* **✅ Handles both Celsius and Fahrenheit conversion correctly**
* **✅ Uses `switch` statement properly**
* **✅ Uses `double.TryParse()` to validate user input safely**
* **✅ Well-formatted output with 2 decimal places**
* **✅ Accepts lowercase/uppercase input via `.Trim().ToUpper()`**
* **✅ Gracefully rejects invalid number input and direction**

---

### 📌 What could be improved

* **\[–1] Minor typo:** `Farenheit` should be spelled `Fahrenheit`
* No code-level issues — everything is logically sound and safe

---

### ✅ Points Breakdown:

| Points   | Description                                            |
| -------- | ------------------------------------------------------ |
| +5       | Program builds and meets all required criteria         |
| +1       | Clean, idiomatic C#                                    |
| +1       | Proper use of `TryParse()` and string cleaning         |
| +1       | Logical structure and documentation-quality formatting |
| +1       | Stretch goal: input validation and direction checking  |
| **9/10** | **Total**                                              |

---

### 🧠 Alternative Solutions or Notes

You could extract the conversion logic into functions to make it even cleaner:

```csharp
static double ConvertToCelsius(double f) => (f - 32) * 5 / 9;
static double ConvertToFahrenheit(double c) => (c * 9 / 5) + 32;
```

Then call them in `switch`.
