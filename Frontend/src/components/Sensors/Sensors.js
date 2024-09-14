import styles from "./Sensors.module.scss";

export default function Sensors() {
    return (
        <div className={styles.sensors}>
            <h2>Czujniki</h2>
            <p>
                Wilgotność gleby:{" "}
                <span className={styles.soil_moistur}>45%</span>
            </p>
            <p>
                Temperatura: <span className={styles.temperature}>22°C</span>
            </p>
        </div>
    );
}
