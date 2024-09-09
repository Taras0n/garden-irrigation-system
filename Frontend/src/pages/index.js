import styles from "../styles/color.module.scss";

const Index = () => {
    return (
        <>
            <header className={styles.header}>
                <h1>Система автоматичного поливу</h1>
            </header>

            <section className={styles.dashboard}>
                <div className={styles.status}>
                    <h2>Статус системи</h2>
                    <p>Система: <span className={styles['system-status']}>Активна</span></p>
                    <p>Останній полив: <span className={styles['last-watered']}>10 хвилин тому</span></p>
                </div>

                <div className={styles.schedule}>
                    <h2>Графік поливу</h2>
                    <form>
                        <label htmlFor="watering-time">Час поливу:</label>
                        <input type="time" id="watering-time" name="watering-time" />
                        <label htmlFor="watering-days">Дні:</label>
                        <select id="watering-days" name="watering-days" multiple>
                            <option value="monday">Понеділок</option>
                            <option value="tuesday">Вівторок</option>
                            <option value="wednesday">Середа</option>
                            <option value="thursday">Четвер</option>
                            <option value="friday">П'ятниця</option>
                            <option value="saturday">Субота</option>
                            <option value="sunday">Неділя</option>
                        </select>
                        <button type="submit">Зберегти графік</button>
                    </form>
                </div>

                <div className={styles['manual-control']}>
                    <h2>Ручне управління</h2>
                    <button id="toggle-water">Увімкнути полив</button>
                </div>

                <div className={styles.sensors}>
                    <h2>Датчики</h2>
                    <p>Вологість ґрунту: <span className={styles['soil-moisture']}>45%</span></p>
                    <p>Температура: <span className={styles.temperature}>22°C</span></p>
                </div>

                <div className={styles.weather}>
                    <h2>Прогноз погоди</h2>
                    <p>Дощ: <span className={styles['rain-chance']}>20%</span></p>
                    <p>Температура повітря: <span className={styles['forecast-temp']}>21°C</span></p>
                </div>
            </section>

            <footer className={styles.footer}>
                <p>© 2024 Автоматичний полив саду</p>
            </footer>
        </>
    );
}

export default Index;
