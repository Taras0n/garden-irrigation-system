import { useState } from 'react';
import styles from './status.module.scss';

export default function Status() {
    const [isActive, setIsActive] = useState(true);

    const toggleSystem = () => {
        setIsActive(!isActive);
    };

    return (
        <div className={styles.status}>
            <h2>Статус системи</h2>
            <p>
                Система:{" "}
                <span className={`${styles.systemStatus} ${isActive ? styles.active : styles.inactive}`}>
                    {isActive ? "Активна" : "Неактивна"}
                </span>
            </p>
            <p>
                Останній полив:{" "}
                <span className={styles.lastWatered}>10 хвилин тому</span>
            </p>
            <div className={styles.toggleContainer}>
                <label className={styles.switch}>
                    <input type="checkbox" checked={isActive} onChange={toggleSystem} />
                    <span className={styles.slider}></span>
                </label>
            </div>
        </div>
    );
}
