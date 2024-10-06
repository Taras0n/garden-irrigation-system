export default async function handler(req, res) {
    try {
      // Виконуємо запит до вашого ASP.NET Core API
      const response = await fetch('http://localhost:7025/api/system');
      
      // Перевіряємо, чи відповідь успішна
      if (!response.ok) {
        throw new Error(`Failed to fetch data: ${response.status}`);
      }
  
      // Парсимо JSON відповідь
      const data = await response.json();
  
      // Відправляємо дані як відповідь Next.js
      res.status(200).json(data);
    } catch (error) {
      console.error('Error fetching system data:', error);
      res.status(500).json({ message: 'Error fetching system data' });
    }
  }
  