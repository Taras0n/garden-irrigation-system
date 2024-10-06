import { useEffect, useState } from 'react';

export default function Home() {
  const [systemData, setSystemData] = useState(null); // Стан для збереження даних системи
  const [loading, setLoading] = useState(true); // Стан для завантаження
  const [error, setError] = useState(null); // Стан для збереження помилки

  useEffect(() => {
    fetch('/api/system')
      .then(response => {
        if (!response.ok) {
          throw new Error('Failed to fetch system data');
        }
        return response.json();
      })
      .then(data => {
        setSystemData(data); // Записуємо отримані дані у стан
        setLoading(false); // Вимикаємо стан завантаження
      })
      .catch(error => {
        console.error(error);
        setError(error.message); // Записуємо помилку у стан
        setLoading(false); // Вимикаємо стан завантаження
      });
  }, []);

  if (loading) {
    return <div>Loading...</div>; // Показуємо повідомлення про завантаження
  }

  if (error) {
    return <div>Error: {error}</div>; // Показуємо повідомлення про помилку
  }

  if (!systemData) {
    return <div>No data available</div>; // Якщо немає даних, показуємо повідомлення
  }

  return (
    <div>
      <h1>System Data</h1>
      {Array.isArray(systemData) ? (
        systemData.map((data, index) => (
          <div key={index}>
            <h2>System Timestamp: {new Date(data.timestamp).toLocaleString()}</h2>
            <div>
              <h3>Valves:</h3>
              {data.data.system.components.valves.map((valve) => (
                <p key={valve.id}>
                  {valve.name} - {valve.location} - Status: {valve.status ? 'On' : 'Off'}
                </p>
              ))}
            </div>
            <div>
              <h3>Pump:</h3>
              <p>{data.data.system.components.pump.name} - Status: {data.data.system.components.pump.status ? 'On' : 'Off'}</p>
            </div>
            <div>
              <h3>Soil Moisture Sensors:</h3>
              {data.data.system.components.sensors.soilMoistureSensors.map(sensor => (
                <p key={sensor.id}>
                  {sensor.name} - {sensor.location} - Value: {sensor.value}{sensor.unit}
                </p>
              ))}
            </div>
            <div>
              <h3>Temperature Sensor:</h3>
              <p>{data.data.system.components.sensors.temperatureSensor.name} - Value: {data.data.system.components.sensors.temperatureSensor.value}{data.data.system.components.sensors.temperatureSensor.unit}</p>
            </div>
            <div>
              <h3>Water Level Sensor:</h3>
              <p>{data.data.system.components.sensors.waterLevelSensor.name} - Location: {data.data.system.components.sensors.waterLevelSensor.location} - Value: {data.data.system.components.sensors.waterLevelSensor.value}{data.data.system.components.sensors.waterLevelSensor.unit}</p>
            </div>
            <div>
              <h3>Air Humidity Sensor:</h3>
              <p>{data.data.system.components.sensors.airHumiditySensor.name} - Value: {data.data.system.components.sensors.airHumiditySensor.value}{data.data.system.components.sensors.airHumiditySensor.unit}</p>
            </div>
          </div>
        ))
      ) : (
        <div>
          <h2>System Timestamp: {new Date(systemData.timestamp).toLocaleString()}</h2>
          {/* Виводимо компоненти, якщо systemData не є масивом */}
        </div>
      )}
    </div>
  );
}
