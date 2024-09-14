import styles from "./Weather.module.scss";

export default function Weather() {
    return (
        <div className={styles.weather}>
        <h2>Prognoza pogody</h2>
        <p>Deszcz: <span className={styles.rain_chance}>20%</span></p>
        <p>Temperatura powietrza: <span className={styles.forecast_temp}>21°C</span></p>
    </div>
    )

}