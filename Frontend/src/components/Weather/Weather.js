import styles from "./Weather.module.scss";

export default function Weather() {
    return (
        <div className={styles.weather}>
        <h2>Прогноз погоди</h2>
        <p>Дощ: <span className={styles.rain_chance}>20%</span></p>
        <p>Температура повітря: <span className={styles.forecast_temp}>21°C</span></p>
    </div>
    )

}