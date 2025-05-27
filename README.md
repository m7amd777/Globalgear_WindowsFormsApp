# GlobalGear Windows Forms App

A simple desktop shopping application built with C# and Windows Forms.  
Select from a catalogue of branded shirts, adjust quantities, watch an intro video, and proceed to a checkout form—complete with “How did you hear about us?” tracking.

---

## 📦 Features

- **Product Catalog**  
  - Six items: Barca, Porto, Arsen, Juven, GOAT, and Ahly shirts.  
  - Each item shows an image, name, price, and a “+”/“–” quantity selector.

- **Cart Badge**  
  - Live-updating counter in the top-right reflects total items selected.

- **Animated Title**  
  - “GlobalGearBH” types on screen one character at a time at startup.

- **Intro Video**  
  - Embedded Windows Media Player control plays `Resources/video.mp4` automatically.

- **Checkout Form**  
  - After selecting items, click the cart icon to open a second form.  
  - Must choose one of: Instagram, Website, or Word of Mouth.

---

## 🛠️ Tech Stack

- **Language:** C#  
- **Framework:** .NET Framework (Windows Forms)  
- **IDE:** Visual Studio  
- **COM Control:** `AxWMPLib.AxWindowsMediaPlayer` for video playback  
- **Resources:** Embedded images and video in `Resources.resx`

---

## 🚀 Getting Started

1. **Clone the repo**  
   ```bash
   git clone https://github.com/m7amd777/Globalgear_WindowsFormsApp.git
   cd Globalgear_WindowsFormsApp
