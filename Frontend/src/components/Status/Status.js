import { useState } from 'react';
import styles from './Status.module.scss';

export default function Status() {
    const [isActive, setIsActive] = useState(true);

    const toggleSystem = () => {
        setIsActive(!isActive);
    };

    return (
        <div className={styles.status}>
            <h2>Status systemy</h2>
            <p>
                System:{" "}
                <span className={`${styles.systemStatus} ${isActive ? styles.active : styles.inactive}`}>
                    {isActive ? "Aktywna" : "Nieaktywna"}
                </span>
            </p>
            <p>
                Ostatnie podlewanie:{" "}
                <span className={styles.lastWatered}>10 minut temu</span>
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
